using Lab10.Interfaces;
using System;
using System.Drawing;

namespace Lab10.Functions
{
    internal class CotanFunction : ITrigonometricFunction
    {
        static ITrigonometricFunction instance = new CotanFunction();
        static bool pointsCreated = false;
        static PointF[] points = new PointF[750];

        public void Draw(Graphics graphics)
        {
            if (!pointsCreated)
            {
                points = Utils.CreatePoints(points, Cotangent);
                pointsCreated = true;
            }

            graphics.DrawLines(Pens.Blue, points);
        }

        static double Cotangent(double x)
        {
            if (x == 0)
            {
                return 1000;
            }
            return 1.0 / Math.Tan(x);
        }

        internal static ITrigonometricFunction getInstance()
        {
            return instance;
        }
    }
}