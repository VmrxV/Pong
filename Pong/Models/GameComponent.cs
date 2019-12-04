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
        /// ��������� ��������� �������. ��� ��������� �������� ��� ������������� � ��������������.
        /// </summary>
        /// <param name="totalTime">����� ����</param>
        /// <param name="elapsedTime">����� ��������� � ���������� �����</param>
        /// <param name="renderer">��������</param>
        public virtual void Draw(TimeSpan totalTime, TimeSpan elapsedTime, Graphics renderer)
        {
            
        }
    }
}