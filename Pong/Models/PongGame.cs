using System;
using System.Collections.Generic;
using System.Drawing;
using Pong.Processors;

namespace Pong.Models
{
    /// <summary>
    /// Модель игры Pong
    /// </summary>
    public class PongGame
    {
        public PongGame()
        {
            var defaultBatWidth = 100;
            var defaultBatHeight = 10;

            // регистрация компонентов. Начальное состояние сцены.
            _components.AddRange(new GameComponent[] 
            {
                new Statistics(), 
                new GameRegion
                {
                    Width = _areaSize.Width,
                    Height = _areaSize.Height
                },
                new Ball//шар
                {
                    Position = new PointF(_areaSize.Width/2, _areaSize.Height/2),                                               
                    Direction = (float) (Math.PI/2),
                },
                new Bat//Отбивные палочки
                {
                    Size = new SizeF(defaultBatWidth, defaultBatHeight),
                    Position = new PointF(_areaSize.Width / 2 - defaultBatWidth/2f, 0),                    
                },
                new Bat//Отбивные палочки
                {
                    Size = new SizeF(defaultBatWidth, defaultBatHeight),
                    Position = new PointF(_areaSize.Width / 2 - defaultBatWidth/2f, _areaSize.Height - defaultBatHeight),
                }
            });

            _processors.AddRange(new GameProcessor[]
                {
                    new MovingProcessor(),
                    new BallOutProcessor(),
                    new BeatProcessor(),
                    new BatControllingProcessor()
                });
        }

        private SizeF _areaSize = new SizeF(349, 430);

        private readonly List<GameComponent> _components = new List<GameComponent>();
        private readonly List<GameProcessor> _processors = new List<GameProcessor>();

        public void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState)
        {
            foreach (var gameProcessor in _processors)
                gameProcessor.Update(totalTime, elapsedTime, inputState, _components);
        }

        public void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics graphics)
        {
            foreach (var gameObject in _components)
                gameObject.Draw(totalTime, elapsedTime, graphics);
        }
    }
}