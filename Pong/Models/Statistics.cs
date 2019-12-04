using System;
using System.Collections.Generic;
using System.Drawing;

namespace Pong.Models
{
    /// <summary>
    /// Компонент статистики игры
    /// </summary>
    public class Statistics : GameComponent
    {
        public Statistics()
        {
            Sides = new Dictionary<bool, int>()
            {
                { true, 0 }, // верх
                { false, 0 } // низ
            };

            Position = new PointF(5, 5);
        }

        private readonly Font _font = new Font(FontFamily.GenericSerif, 20);

        /// <summary>
        /// Очки. Ключ словаря - идентификатор стороны. true - верх, false - низ
        /// </summary>
        public IDictionary<bool, int> Sides { get; private set; }        

        public override void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics renderer)
        {
            renderer.DrawString(Sides[true] + " : " + Sides[false], _font, Brushes.Black,Position.X,430);
			truefalse.l1 =Convert.ToString( Sides[true]);
			truefalse.l3 = Convert.ToString(Sides[false]);
			if (Convert.ToString( Sides[true]) ==Convert.ToString(5))
            {
                renderer.DrawString("Победа" + " : " + "Порожение", _font, Brushes.Black, Position.X, 430);
            }
            if (Convert.ToString(Sides[false]) == Convert.ToString(5))
            {
                renderer.DrawString("Порожение" + " : " + "Победа", _font, Brushes.Black, Position.X, 430);
            }
        }        
    }
}