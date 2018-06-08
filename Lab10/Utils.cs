using System;
using System.Drawing;

namespace Lab10
{
    class Utils
    {
        internal static PointF[] CreatePoints(PointF[] points, Func<double, double> func)
        {
            float x0 = 0f;
            float y0 = 150f;

            for (int i = 0; i < 750; i++)
            {
                points[i] = new PointF();
                points[i].X = x0 + i;
                var y = y0 - (float)(func((2 * Math.PI * i) / 375) * (375 / (2 * Math.PI)));
                y = Math.Min(y, 1000);
                points[i].Y = y;
            }

            return points;
        }

        internal static object CreatePoints(object pointsCotan, Func<double, double> cotangent)
        {
            throw new NotImplementedException();
        }
    }
}
