using System.Windows.Forms;
namespace ExerciseNo6
{
    public partial class Form1 : Form
    {
        private int timeLeft;
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            if (timeLeft > 0)
            {
                label3.Visible = true;
                label3.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Time Over", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = (int)numericUpDown1.Value;
            if(timeLeft > 0)
            {
                timer1.Interval = 1000;
                timer1.Start();
                label3.Visible = true;
                label3.Text = timeLeft + " seconds";
            }
            else
            {
                MessageBox.Show("Please enter a positive number of seconds.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
