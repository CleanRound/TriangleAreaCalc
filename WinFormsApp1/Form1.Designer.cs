namespace TriangleAreaCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textBoxSideA = new TextBox();
            textBoxSideB = new TextBox();
            textBoxAngle = new TextBox();
            buttonCalculate = new Button();
            labelSideA = new Label();
            labelSideB = new Label();
            labelAngle = new Label();
            labelResult = new Label();
            SuspendLayout();

            textBoxSideA.Location = new Point(220, 30);
            textBoxSideA.Name = "textBoxSideA";
            textBoxSideA.Size = new Size(100, 23);
            textBoxSideA.TabIndex = 0;

            textBoxSideB.Location = new Point(220, 70);
            textBoxSideB.Name = "textBoxSideB";
            textBoxSideB.Size = new Size(100, 23);
            textBoxSideB.TabIndex = 1;

            textBoxAngle.Location = new Point(220, 110);
            textBoxAngle.Name = "textBoxAngle";
            textBoxAngle.Size = new Size(100, 23);
            textBoxAngle.TabIndex = 2;

            buttonCalculate.Location = new Point(145, 150);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 30);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Calculate Area";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;

            labelSideA.AutoSize = true;
            labelSideA.Location = new Point(30, 30);
            labelSideA.Name = "labelSideA";
            labelSideA.Size = new Size(171, 15);
            labelSideA.TabIndex = 4;
            labelSideA.Text = "Enter the length of side A (cm):";

            labelSideB.AutoSize = true;
            labelSideB.Location = new Point(30, 70);
            labelSideB.Name = "labelSideB";
            labelSideB.Size = new Size(170, 15);
            labelSideB.TabIndex = 5;
            labelSideB.Text = "Enter the length of side B (cm):";

            labelAngle.AutoSize = true;
            labelAngle.Location = new Point(30, 110);
            labelAngle.Name = "labelAngle";
            labelAngle.Size = new Size(153, 15);
            labelAngle.TabIndex = 6;
            labelAngle.Text = "Enter the angle between (°):";

            labelResult.AutoSize = true;
            labelResult.Location = new Point(30, 200);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 15);
            labelResult.TabIndex = 7;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(labelResult);
            Controls.Add(labelAngle);
            Controls.Add(labelSideB);
            Controls.Add(labelSideA);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxAngle);
            Controls.Add(textBoxSideB);
            Controls.Add(textBoxSideA);
            Name = "Form1";
            Text = "Triangle Area Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSideA;
        private System.Windows.Forms.TextBox textBoxSideB;
        private System.Windows.Forms.TextBox textBoxAngle;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelSideA;
        private System.Windows.Forms.Label labelSideB;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelResult;
    }
}
