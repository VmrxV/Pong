using System;
using System.Collections.Generic;
using System.Linq;
using Pong.Helpers;
using Pong.Models;

namespace Pong.Processors
{
    /// <summary>
    /// ќбработчик отскока шара от ракетки
    /// </summary>
    public class BeatProcessor : GameProcessor
    {
        #region Overrides of GameProcessor

        public override void Update(TimeSpan totalTime, TimeSpan elapsedTime, InputState inputState, IList<GameComponent> components)
        {
            var region = components.OfType<GameRegion>().FirstOrDefault();
            var ball = components.OfType<Ball>().FirstOrDefault();
            if (ball != null && region != null)
            {
                // »щем ракетку, в которую ударилс€ шар
                var bat =
                    components.OfType<Bat>()
                        .FirstOrDefault(
                            b => GeometryHelper.CircleIntercectsRectangle(ball.Position.X, ball.Position.Y, ball.Radius,
                                b.Position.X, b.Position.Y, b.Size.Width, b.Size.Height));

                if (bat != null)
                {
                    var side = bat.Position.Y < region.Height / 2;
                    var k = ((ball.Position.X-bat.Position.X)/bat.Size.Width - 0.5) * (side ? -1 : 1);
                    ball.Direction = (float) ((side ? 0 : Math.PI) + Math.PI/2 + Math.PI/2*k);
                    ball.Speed += 2f;
                    if (ball.Speed > 100)
                        ball.Speed = 100;
                }
            }
        }

        #endregion
    }
}