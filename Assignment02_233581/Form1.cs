namespace Assignment02_233581
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBox1();
            dateTimePicker1.ValueChanged += new EventHandler(dateTimePicker1_ValueChanged);
            monthCalendar1.DateChanged += new DateRangeEventHandler(monthCalendar1_DateChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Font oldFont = this.richTextBox1.SelectionFont;
            Font newFont;

            if (oldFont != null)
            {

                if (oldFont.Italic)
                {
                    newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
                }
                else
                {
                    newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
                }
            }
            else
            {
                newFont = new Font("Arial", 12, FontStyle.Regular | FontStyle.Underline);
            }

            this.richTextBox1.SelectionFont = newFont;
            this.richTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string items = "";

            if (checkBox1.Checked)
                items += "\n Pencil";

            if (checkBox2.Checked)
                items += "\n Sharpener";

            if (checkBox3.Checked)
                items += "\n Pen";

            if (items.Length > 0)
            {
                label1.Text = "You have bought:" + items;
            }
            else
            {
                label1.Text = "Please select at least one item to buy.";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gender;

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Unknown";
            }

            MessageBox.Show("Selected gender: " + gender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal price = numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;

            decimal total = price * quantity;

            MessageBox.Show(String.Format("The total price is {0:C}", total));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;

            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void InitializeComboBox1()
        {
            string[] names = { "Tamil Nadu", "Kerala", "Telangana", "Andhra", "Delhi" };

            foreach (string name in names)
            {
                comboBox1.Items.Add(name);
            }

            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Tamil Nadu")
            {
                comboBox2.Items.Add("Chennai");
                comboBox2.Items.Add("Trichy");
                comboBox2.Items.Add("Pondicherry");
                comboBox2.Items.Add("Madurai");
                comboBox2.Items.Add("Kanchipuram");
            }

            else if (comboBox1.SelectedItem.ToString() == "Kerala")
            {
                comboBox2.Items.Add("Kolam");
                comboBox2.Items.Add("Cochin");
                comboBox2.Items.Add("Thiruvananthapuram");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label15.Text = "DateTimePicker Date: " + dateTimePicker1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label16.Text = "Month Calendar Date: " + monthCalendar1.SelectionStart.ToLongDateString();
        }
    }
}
