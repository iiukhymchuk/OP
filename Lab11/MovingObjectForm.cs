using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab11
{
    public partial class MovingObjectForm : Form
    {
        int x;
        int y;
        int xDirection;
        int yDirection;
        int pictureHeight;
        int pictureWidth;

        public MovingObjectForm()
        {
            InitializeComponent();
            var random = new Random();
            x = 300;
            y = 100;
            xDirection = (int)(random.NextDouble() * 10) * ((random.Next() % 2) == 0 ? -1 : 1);
            yDirection = (int)(random.NextDouble() * 10) * ((random.Next() % 2) == 0 ? -1 : 1);
            pictureHeight = 200;
            pictureWidth = 200;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            Point startPoint = new Point(x, y);
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.Racoon), startPoint);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var borderWidth = PictureBox.Size.Width;
            var borderHeight = PictureBox.Size.Height;

            if (x <= 0 || x >= borderWidth - pictureWidth)
            {
                xDirection *= -1;
            }
            if (y <= 0 || y >= borderHeight - pictureHeight)
            {
                yDirection *= -1;
            }

            x += xDirection;
            y += yDirection;

            PictureBox.Invalidate();
        }
    }
}
