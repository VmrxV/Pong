using System;
using System.Drawing;

namespace Pong.Models
{
    /// <summary>
    /// Ракетка
    /// </summary>
    public class Bat : GameComponent
    {
        private Brush _fill = new SolidBrush(Color.Crimson);

        public SizeF Size { get; set; }
        
        public override void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics renderer)
        {
            renderer.FillRectangle(_fill, Position.X, Position.Y, Size.Width, Size.Height);
        }
    }
}