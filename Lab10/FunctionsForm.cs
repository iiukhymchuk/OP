using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FunctionsForm : Form
    {
        static Graphics graphics;
        static string previousFunctionName;

        static PointF[] pointsSin = new PointF[750];
        static bool pointsCreatedSin = false;
        static PointF[] pointsCos = new PointF[750];
        static bool pointsCreatedCos = false;
        static PointF[] pointsTan = new PointF[750];
        static bool pointsCreatedTan = false;
        private PointF[] pointsCotan = new PointF[750];
        private bool pointsCreatedCotan = false;

        public FunctionsForm()
        {
            InitializeComponent();

            graphics = graphBox.CreateGraphics();
            FunctionsComboBox.SelectedIndex = 0;
            graphics.Clear(Color.LightGray);
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var functionName = this.FunctionsComboBox.Text;
            if (functionName == previousFunctionName || string.IsNullOrEmpty(functionName))
            {
                return;
            }
            previousFunctionName = functionName;

            graphics.Clear(Color.LightGray);
            if (functionName == "sin(x)")
            {
                if (!pointsCreatedSin)
                {
                    pointsSin = Utils.CreatePoints(pointsSin, Math.Sin);
                    pointsCreatedSin = true;
                }

                graphics.DrawLines(Pens.Blue, pointsSin);
            }
            else if (functionName == "cos(x)")
            {
                if (!pointsCreatedCos)
                {
                    pointsCos = Utils.CreatePoints(pointsCos, Math.Cos);
                    pointsCreatedCos = true;
                }

                graphics.DrawLines(Pens.Blue, pointsCos);
            }
            else if (functionName == "tan(x)")
            {
                if (!pointsCreatedTan)
                {
                    pointsTan = Utils.CreatePoints(pointsTan, Math.Tan);
                    pointsCreatedTan = true;
                }

                graphics.DrawLines(Pens.Blue, pointsTan);
            }
            else if (functionName == "cotan(x)")
            {
                if (!pointsCreatedCotan)
                {
                    pointsCotan = Utils.CreatePoints(pointsCotan, Cotangent);
                    pointsCreatedCotan = true;
                }

                graphics.DrawLines(Pens.Blue, pointsCotan);
            }

            Coordinates.DrawCoordinates(graphics);
        }

        static double Cotangent(double x)
        {
            if (x == 0)
            {
                return 1000;
            }
            return 1.0 / Math.Tan(x);
        }

        void FunctionsForm_Paint(object sender, PaintEventArgs e)
        {
            Coordinates.DrawCoordinates(graphics);
        }
    }
}
