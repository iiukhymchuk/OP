using Lab10.Interfaces;
using System;
using System.Drawing;

namespace Lab10.Functions
{
    internal class CotanFunction : ITrigonometricFunction
    {
        static bool pointsCreated = false;
        PointF[] points = new PointF[375];

        public void Draw(Graphics graphics)
        {
            if (!pointsCreated)
            {
                CreatePoints(points);
            }

            graphics.DrawLines(Pens.Blue, points);
        }

        static void CreatePoints(PointF[] points)
        {
            float x0 = 0f;
            float y0 = 150f;

            for (int i = 0; i < 375; i++)
            {
                points[i] = new PointF();
                points[i].X = x0 + 2 * i;
                var y = y0 - (float)(Cotangent((2 * Math.PI * i) / 187.5) * (187.5 / (2 * Math.PI)));
                y = Math.Min(y, 150);
                points[i].Y = y;
            }

            pointsCreated = true;
        }

        static double Cotangent(double x)
        {
            if (x == 0)
            {
                return 1000;
            }
            return 1.0 / Math.Tan(x);
        }
    }
}