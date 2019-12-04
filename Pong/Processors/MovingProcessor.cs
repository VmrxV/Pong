using System;
using System.Collections.Generic;
using System.Drawing;
using Pong.Models;

namespace Pong.Processors
{
    /// <summary>
    /// ���������� ������������ �������� �����
    /// </summary>
    public class MovingProcessor : GameProcessor
    {
        #region Overrides of GameProcessor

        public override void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState, IList<GameComponent> components)
        {
            foreach (var gameObject in components)
            {
                // ��������, ���������� �� �������
                var frameStep = (1f/elapsedTime.Milliseconds)*gameObject.Speed;
                var delta = new PointF((float) Math.Cos(gameObject.Direction) * frameStep, (float) Math.Sin(gameObject.Direction) * frameStep);
                gameObject.Position = new PointF(gameObject.Position.X + delta.X, gameObject.Position.Y + delta.Y);
            }
        }

        #endregion
    }
}