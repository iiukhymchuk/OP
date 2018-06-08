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

            var function = FunctionFactory.Create(functionName);
            graphics.Clear(Color.LightGray);
            function.Draw(graphics);

            Coordinates.DrawCoordinates(graphics);
        }

        private void FunctionsForm_Paint(object sender, PaintEventArgs e)
        {
            Coordinates.DrawCoordinates(graphics);
        }
    }
}
