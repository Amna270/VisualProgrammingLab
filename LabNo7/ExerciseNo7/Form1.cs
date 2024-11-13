namespace ExerciseNo7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IntailizeClock();
        }
        private void IntailizeClock()
        {
            timer1.Interval = 1000;
            timer1.Start();
            UpdateDateTime();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }
        private void UpdateDateTime()
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString("dddd,MMMM dd,yyyy");
            label2.Text = dt.ToString("hh:mm:ss tt");
        }
    }
}
