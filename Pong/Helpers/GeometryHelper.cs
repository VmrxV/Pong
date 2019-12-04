using System;

namespace Pong.Helpers
{
    public static class GeometryHelper
    {
        private static float Clamp(float val, float min, float max)
        {
            return Math.Max(min, Math.Min(max, val));
        }

        public static bool CircleIntercectsRectangle(float cx, float cy, float cr, float rx, float ry, float rw, float rh)
        {            
            // Find the closest point to the circle within the rectangle
            // Assumes axis alignment! ie rect must not be rotated
            var closestX = Clamp(cx, rx, rx + rw);
            var closestY = Clamp(cy, ry, ry + rh);

            // Calculate the distance between the circle's center and this closest point
            var distanceX = cx - closestX;
            var distanceY = cy - closestY;

            // If the distance is less than the circle's radius, an intersection occurs
            var distanceSquared = (distanceX * distanceX) + (distanceY * distanceY);
            return distanceSquared < (cr * cr);
        }
    }
}