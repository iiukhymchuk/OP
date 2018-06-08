using Lab10.Interfaces;
using System;
using System.Drawing;

namespace Lab10.Functions
{
    internal class CosFunction : ITrigonometricFunction
    {
        static bool pointsCreated = false;
        PointF[] points = new PointF[750];

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

            for (int i = 0; i < 750; i++)
            {
                points[i] = new PointF();
                points[i].X = x0 + i;
                points[i].Y = y0
                    - (float)(Math.Cos((2 * Math.PI * i) / 375) * (375 / (2 * Math.PI)));
            }

            pointsCreated = true;
        }
    }
}