using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FunctionsForm : Form
    {
        static Graphics graphics;

        public FunctionsForm()
        {
            InitializeComponent();

            graphics = graphBox.CreateGraphics();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            Coordinates.DrawCoordinates(graphics);
        }

        private void FunctionsForm_Paint(object sender, PaintEventArgs e)
        {
            Coordinates.DrawCoordinates(graphics);
        }
    }
}
