namespace EcerciseNo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            double cel = (f - 32) * 5 / 9;
            textBox2.Text = cel.ToString("F4");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
