using System.Drawing;
using System.Windows.Forms;

namespace Lab13
{
    public partial class MoveWithMouse : Form
    {
        private Point firstPoint;

        public MoveWithMouse()
        {
            InitializeComponent();
        }

        public void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                firstPoint = Control.MousePosition;
            }
        }

        public void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point temp = Control.MousePosition;
                Point res = new Point(firstPoint.X - temp.X, firstPoint.Y - temp.Y);

                pictureBox1.Location = new Point(pictureBox1.Location.X - res.X, pictureBox1.Location.Y - res.Y);

                firstPoint = temp;

                pictureBox1.Invalidate();
            }
        }
    }
}
