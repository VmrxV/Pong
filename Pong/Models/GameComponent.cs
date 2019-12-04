using System;
using System.Drawing;

namespace Pong.Models
{
    public abstract class GameComponent
    {
        public PointF Position { get; set; }
        public float Speed { get; set; }
        public float Direction { get; set; }        
        public PointF Anchor { get; set; }        

        /// <summary>
        /// Процедура отрисовки объекта. Для невидимых объектов нет необходимости её переопределять.
        /// </summary>
        /// <param name="totalTime">Время игры</param>
        /// <param name="elapsedTime">Время прошедшее с последнего кадра</param>
        /// <param name="renderer">Рендерер</param>
        public virtual void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics renderer)
        {
            
        }
    }
}