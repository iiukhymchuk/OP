using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab12
{
    public partial class MoveWithKeyboardForm : Form
    {
        int xRaccoon1;
        int yRaccoon1;
        int xRaccoon2;
        int yRaccoon2;
        int xActive;
        int yActive;
        Raccoon currentActive;
        Pen pen;

        public MoveWithKeyboardForm()
        {
            InitializeComponent();
            xRaccoon1 = 200;
            yRaccoon1 = 100;
            xRaccoon2 = 600;
            yRaccoon2 = 100;

            xActive = xRaccoon1 - 2;
            yActive = yRaccoon1 - 2;
            currentActive = Raccoon.First;

            pen = new Pen(Color.Black, 2f);
        }

        private void MoveWithKeyboardForm_Paint(object sender, PaintEventArgs e)
        {
            Point startPointRaccoon1 = new Point(xRaccoon1, yRaccoon1);
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.Raccoon2), startPointRaccoon1);
            Point startPointRaccoon2 = new Point(xRaccoon2, yRaccoon2);
            Size size = new Size(180, 180);
            e.Graphics.DrawImage(new Bitmap(Properties.Resources.Raccoon3, size), startPointRaccoon2);
            e.Graphics.DrawRectangle(pen, xActive, yActive, 184, 184);
        }

        private void OnKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(9)))
            {
                if (currentActive == Raccoon.First)
                {
                    xActive = xRaccoon2 - 2;
                    yActive = yRaccoon2 - 2;
                    currentActive = Raccoon.Second;
                }
                else if (currentActive == Raccoon.Second)
                {
                    xActive = xRaccoon1 - 2;
                    yActive = yRaccoon1 - 2;
                    currentActive = Raccoon.First;
                }
            }

            // Up
            if (e.KeyChar.Equals(Convert.ToChar(119))) //W
            {
                if (currentActive == Raccoon.First)
                {
                    yRaccoon1 -= 10;
                }
                else if (currentActive == Raccoon.Second)
                {
                    yRaccoon2 -= 10;
                }
                yActive -= 10;
            }

            // Down
            if (e.KeyChar.Equals(Convert.ToChar(115))) // S
            {
                if (currentActive == Raccoon.First)
                {
                    yRaccoon1 += 10;
                }
                else if (currentActive == Raccoon.Second)
                {
                    yRaccoon2 += 10;
                }
                yActive += 10;
            }

            // Left
            if (e.KeyChar.Equals(Convert.ToChar(97))) // A
            {
                if (currentActive == Raccoon.First)
                {
                    xRaccoon1 -= 10;
                }
                else if (currentActive == Raccoon.Second)
                {
                    xRaccoon2 -= 10;
                }
                xActive -= 10;
            }

            // Left
            if (e.KeyChar.Equals(Convert.ToChar(100))) // D
            {
                if (currentActive == Raccoon.First)
                {
                    xRaccoon1 += 10;
                }
                else if (currentActive == Raccoon.Second)
                {
                    xRaccoon2 += 10;
                }
                xActive += 10;
            }

            Invalidate();
        }
    }
}
