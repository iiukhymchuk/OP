using Lab10.Functions;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FunctionsForm : Form
    {
        static Graphics graphics;
        static string previousFunctionName;


        public FunctionsForm()
        {
            InitializeComponent();

            graphics = graphBox.CreateGraphics();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            var functionName = this.FunctionsComboBox.Text;
            if (functionName == previousFunctionName || functionName == string.Empty)
            {
                return;
            }
            previousFunctionName = functionName;

            var function = FunctionFactory.Create(functionName);
            function.Draw(graphics);

            //Coordinates.DrawCoordinates(graphics);
        }

        private void FunctionsForm_Paint(object sender, PaintEventArgs e)
        {
            Coordinates.DrawCoordinates(graphics);
        }
    }
}
