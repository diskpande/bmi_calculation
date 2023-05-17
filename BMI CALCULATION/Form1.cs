namespace BMI_CALCULATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kiloTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            double kilo = Convert.ToDouble(kiloTextBox.Text);
            double height = Convert.ToDouble(heightTextBox.Text) /100;

            double bmi = kilo / (height * height);

            if (bmi < 18.5)
            {
                statusTextBox.Text = "UNDERWEIGHT";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                statusTextBox.Text = "NORMAL";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                statusTextBox.Text = "OVERWEIGHT";
            }
            else
            {
                statusTextBox.Text = "OBESE";
            }

            label3.Text = "Your BMI : " + Math.Round(bmi, 2).ToString();
        }
    }
}