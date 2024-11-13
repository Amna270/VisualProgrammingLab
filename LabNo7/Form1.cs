namespace LabNo7_ActivityNo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Large");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label5.Text = $"Your Order Details: \n Size: {comboBox1.Text} \n Toppings: ";
            if(checkBox1.Checked)
            {
                label5.Text += $"{checkBox1.Text} ";
            }
            if (checkBox2.Checked)
            {
                label5.Text += $"{checkBox2.Text} ";
            }
            if (checkBox3.Checked)
            {
                label5.Text += $"{checkBox3.Text} ";
            }
            label5.Text += $"\nCurst Type: ";
            if (radioButton1.Checked)
            {
                label5.Text += $"{radioButton1.Text}";
            }
            if (radioButton2.Checked)
            {
                label5.Text += $"{radioButton2.Text}";
            }
        }
    }
}