namespace Lab10
{
    partial class FunctionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FunctionsLabel = new System.Windows.Forms.Label();
            this.FunctionsComboBox = new System.Windows.Forms.ComboBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.graphBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionsLabel
            // 
            this.FunctionsLabel.AutoSize = true;
            this.FunctionsLabel.Location = new System.Drawing.Point(47, 31);
            this.FunctionsLabel.Name = "FunctionsLabel";
            this.FunctionsLabel.Size = new System.Drawing.Size(78, 13);
            this.FunctionsLabel.TabIndex = 0;
            this.FunctionsLabel.Text = "Select function\r\n";
            // 
            // FunctionsComboBox
            // 
            this.FunctionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionsComboBox.FormattingEnabled = true;
            this.FunctionsComboBox.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)",
            "tan(x)",
            "cotan(x)"});
            this.FunctionsComboBox.Location = new System.Drawing.Point(162, 31);
            this.FunctionsComboBox.Name = "FunctionsComboBox";
            this.FunctionsComboBox.Size = new System.Drawing.Size(121, 21);
            this.FunctionsComboBox.TabIndex = 1;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(358, 31);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 2;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // graphBox
            // 
            this.graphBox.ErrorImage = null;
            this.graphBox.InitialImage = null;
            this.graphBox.Location = new System.Drawing.Point(20, 100);
            this.graphBox.Margin = new System.Windows.Forms.Padding(0);
            this.graphBox.MaximumSize = new System.Drawing.Size(750, 300);
            this.graphBox.Name = "graphBox";
            this.graphBox.Size = new System.Drawing.Size(750, 300);
            this.graphBox.TabIndex = 0;
            this.graphBox.TabStop = false;
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.graphBox);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.FunctionsComboBox);
            this.Controls.Add(this.FunctionsLabel);
            this.Name = "FunctionsForm";
            this.Text = "Trigonometry Draw";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FunctionsForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.graphBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionsLabel;
        private System.Windows.Forms.ComboBox FunctionsComboBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox graphBox;
    }
}

