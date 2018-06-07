using System.Drawing;

namespace Lab10
{
    class Coordinates
    {
        static Pen pen = new Pen(Color.Black, 1);
        static Point xStart = new Point(0, 150);
        static Point xEnd = new Point(750, 150);
        static Point yStart = new Point(375, 0);
        static Point yEnd = new Point(375, 300);

        internal static void DrawCoordinates(Graphics graphics)
        {
            graphics.DrawLine(pen, xStart, xEnd);
            graphics.DrawLine(pen, yStart, yEnd);
        }
    }
}
