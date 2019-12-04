using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Pong.Models;

namespace Pong.Processors
{
    /// <summary>
    /// Обработчик для управления ракетками
    /// </summary>
    public class BatControllingProcessor : GameProcessor
    {
        private float _step = 20;

        #region Overrides of GameProcessor

        public override void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState, IList<GameComponent> components)
        {            
            var region = components.OfType<GameRegion>().FirstOrDefault();
            var bat1 = components.OfType<Bat>().First();
            var bat2 = components.OfType<Bat>().Last();
            if (region != null)
            {
                var delta = 1f / elapsedTime.Milliseconds * _step;
                
                if (inputState.PressedKeys.Contains(Keys.A))
                    bat1.Position = new PointF(Math.Max(bat1.Position.X - delta,0), bat1.Position.Y);
                if (inputState.PressedKeys.Contains(Keys.D))
                    bat1.Position = new PointF(Math.Min(bat1.Position.X + delta, region.Width - bat1.Size.Width), bat1.Position.Y);
                if (inputState.PressedKeys.Contains(Keys.Left))
                    bat2.Position = new PointF(Math.Max(bat2.Position.X - delta, 0), bat2.Position.Y);
                if (inputState.PressedKeys.Contains(Keys.Right))
                    bat2.Position = new PointF(Math.Min(bat2.Position.X + delta, region.Width - bat2.Size.Width), bat2.Position.Y);                
            }
        }

        #endregion
    }
}