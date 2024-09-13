using System;
using System.Windows.Forms;

namespace TriangleAreaCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double sideA = double.Parse(textBoxSideA.Text);
                double sideB = double.Parse(textBoxSideB.Text);
                double angleDegrees = double.Parse(textBoxAngle.Text);

                double angleRadians = angleDegrees * (Math.PI / 180.0);

                double area = 0.5 * sideA * sideB * Math.Sin(angleRadians);

                labelResult.Text = "Area of the triangle: " + area.ToString("0.00") + " square centimeters";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
