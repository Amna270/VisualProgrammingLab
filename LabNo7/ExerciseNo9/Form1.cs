namespace ExerciseNo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = textBox1.TextLength.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int left=160-textBox1.TextLength;
            label2.Text=left.ToString();
        }
    }
}
