using Lab10.Interfaces;
using System;
using System.Drawing;

namespace Lab10.Functions
{
    class SinFunction : ITrigonometricFunction
    {
        static ITrigonometricFunction instance = new SinFunction();
        static bool pointsCreated = false;
        static PointF[] points = new PointF[750];

        public void Draw(Graphics graphics)
        {
            if (!pointsCreated)
            {
                points = Utils.CreatePoints(points, Math.Sin);
                pointsCreated = true;
            }

            graphics.DrawLines(Pens.Blue, points);
        }

        internal static ITrigonometricFunction getInstance()
        {
            return instance;
        }
    }
}
