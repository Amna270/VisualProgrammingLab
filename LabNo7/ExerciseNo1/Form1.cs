namespace ExerciseNo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 + num2;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 - num2;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = num1 * num2;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            if(num2!=0)
            {
                double result = num1/num2;
                textBox3.Text = result.ToString();
            }
            else
            {
                textBox3.Text = "Cannot Divide by zero!";
            }
        }
    }
}
