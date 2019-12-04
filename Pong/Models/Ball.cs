using System;
using System.Drawing;

namespace Pong.Models
{
    /// <summary>
    /// Шар
    /// </summary>
    public class Ball : GameComponent
    {
        public Ball()
        {
            Speed = 30;
            Radius = 10;
            Anchor = new PointF(0.5f, 0.5f);
        }

        private Brush _fill = new SolidBrush(Color.Black);        

        public float Radius { get; set; }

        public override void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics renderer)
        {
            renderer.FillEllipse(_fill, Position.X - Anchor.X*Radius*2, Position.Y - Anchor.Y * Radius*2, Radius*2, Radius*2);
        }
    }
}