using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Pong.Models;

namespace Pong.Processors
{
    /// <summary>
    /// ���������� ������ ���� �� ������� �������� ����    
    /// </summary>
    public class BallOutProcessor : GameProcessor
    {
        private TimeSpan? _outTime;
        private TimeSpan _respawnInterval = TimeSpan.FromSeconds(2);
        private Random _random = new Random();
        private bool _outSide;

        #region Overrides of GameProcessor

        public override void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState, IList<GameComponent> components)
        {
            var region = components.OfType<GameRegion>().FirstOrDefault();
            var ball = components.OfType<Ball>().FirstOrDefault();
            var scores = components.OfType<Statistics>().FirstOrDefault();
            if (ball != null && region != null)
            {
                // ������ �� ����� � ������ �������
                if (ball.Position.X > region.Width - ball.Radius || ball.Position.X < ball.Radius)
                {
                    ball.Direction = (float) (Math.PI - ball.Direction);
                }

                // ��������� ����� ��� ������ �� ������ ��� ������� �������
                if (ball.Position.Y > region.Height || ball.Position.Y < 0)
                {
                    // �������� ����
                    components.Remove(ball);
                    // �������� ������� ��������, ��� ������������ �������������� ����
                    _outTime = totalTime;     
                    if(scores != null)
                    {
                        _outSide = ball.Position.Y < region.Height/2;
                        ++scores.Sides[!_outSide];
                    }
                }
            }

            // �������������� ���������� ���� ����� �������� ����
            if (totalTime - _outTime >= _respawnInterval)
            {
                _outTime = null;
                ball = new Ball
                {
                    Position = new PointF(region.Width/2, region.Height/2),
                    Direction = (float) ((_outSide ? Math.PI : 0) + Math.PI/2 + (Math.PI/4) * (_random.NextDouble()-0.5f))
                };
                components.Add(ball);
            }
        }

        #endregion
    }
}