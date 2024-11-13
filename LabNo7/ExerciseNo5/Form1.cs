namespace ExerciseNo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fac=Convert.ToInt32(textBox1.Text);
            if(ValidateInput())
            {
                int num = int.Parse(textBox1.Text);
                int f = 1;
                for(int i=1; i<=num; i++)
                {
                    f = f * i;
                }
                textBox2.Text = f.ToString();
            }
        }
        private bool ValidateInput()
        {
            string input = textBox1.Text;
            int number=int.Parse(input);
          
            if (number < 0)
            {
                MessageBox.Show("Please enter a non-negative integer.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(number>20)
            {
                MessageBox.Show("Please enter a number less than or equal to 20.", "Input Too Large", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
