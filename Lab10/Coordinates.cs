using System.Drawing;
using System.Drawing.Drawing2D;

namespace Lab10
{
    class Coordinates
    {
        static Pen pen = new Pen(Color.Black, 1);
        static Point xStart = new Point(0, 150);
        static Point xEnd = new Point(750, 150);
        static Point yStart = new Point(375, 300);
        static Point yEnd = new Point(375, 0);

        internal static void DrawCoordinates(Graphics graphics)
        {
            pen.EndCap = LineCap.ArrowAnchor;

            graphics.DrawLine(pen, xStart, xEnd);
            graphics.DrawLine(pen, yStart, yEnd);

            graphics.DrawString("-3/2π", SystemFonts.DefaultFont, Brushes.Black, 93.75f, 150);
            graphics.DrawString("-π", SystemFonts.DefaultFont, Brushes.Black, 187.5f, 150);
            graphics.DrawString("-π/2", SystemFonts.DefaultFont, Brushes.Black, 281.25f, 150);
            graphics.DrawString("0", SystemFonts.DefaultFont, Brushes.Black, 375, 150);
            graphics.DrawString("π/2", SystemFonts.DefaultFont, Brushes.Black, 468.75f, 150);
            graphics.DrawString("π", SystemFonts.DefaultFont, Brushes.Black, 562.5f, 150);
            graphics.DrawString("3/2π", SystemFonts.DefaultFont, Brushes.Black, 656.25f, 150);

            graphics.DrawString("1", SystemFonts.DefaultFont, Brushes.Black, 375, 86.3f);
            graphics.DrawString("-1", SystemFonts.DefaultFont, Brushes.Black, 375, 213.7f);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }
    }
}
