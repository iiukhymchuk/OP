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
            this.DrawButton = new System.Windows.Forms.Button();
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
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(337, 31);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 23);
            this.DrawButton.TabIndex = 2;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // FunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DrawButton);
            this.Controls.Add(this.FunctionsComboBox);
            this.Controls.Add(this.FunctionsLabel);
            this.Name = "FunctionsForm";
            this.Text = "Trigonometry Draw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionsLabel;
        private System.Windows.Forms.ComboBox FunctionsComboBox;
        private System.Windows.Forms.Button DrawButton;
    }
}

