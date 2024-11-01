namespace Assignment02_233581
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitailizeLabel();
            InitailizeTextBox();
            InitailizeRichTextBox();
            InitializeCheckBox();
            InitializeRdioButton();
            InitializeComboBox();
            InitializeNumericUpdown();
            InitializeDateTimePicker();
            InitializeMonthCalendar();
            InitializePictureBox();
        }

       private void InitailizeLabel()
        {
            Label label=new Label();
            label.Text = "This is a Label!";
            label.Location = new System.Drawing.Point(20, 20);
            label.AutoSize = true;
            this.Controls.Add(label);
        }
        private void InitailizeTextBox()
        {
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(150, 20);
            this.Controls.Add(textBox);
        }
        private void InitailizeRichTextBox()
        {
            RichTextBox richtextBox = new RichTextBox();
            richtextBox.Location = new System.Drawing.Point(20, 50);
            richtextBox.Size = new System.Drawing.Size(200, 50);
            richtextBox.Text = "This is RichTextBox";
            this.Controls.Add(richtextBox);
        }
        private void InitializeCheckBox()
        {
            CheckBox checkBox=new CheckBox();
            checkBox.Text = "I agree to the terms and conditions.";
            checkBox.Location = new System.Drawing.Point(20, 120);
            checkBox.AutoSize = true;
            this.Controls.Add(checkBox);
        }
        private void InitializeRdioButton()
        {
            RadioButton radioButton1 = new RadioButton();
            radioButton1.Text = "Option 1";
            radioButton1.Location = new System.Drawing.Point(120, 150);
            this.Controls.Add(radioButton1);
        }
        private void InitializeComboBox()
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Location = new System.Drawing.Point(20, 180);
            comboBox.Items.AddRange(new string[] { "Choice 1", "Choice 2", "Choice 3" });
            this.Controls.Add(comboBox);
        }
        private void InitializeNumericUpdown()
        {
            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Location = new System.Drawing.Point(20, 220);
            numericUpDown.Minimum = 1;
            numericUpDown.Maximum = 10;
            this.Controls.Add(numericUpDown);
        }
        private void InitializeDateTimePicker()
        {
            DateTimePicker dateTimePicker = new DateTimePicker();
            dateTimePicker.Location = new System.Drawing.Point(20, 260);
            this.Controls.Add(dateTimePicker);
        }
        private void InitializeMonthCalendar()
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.Location = new System.Drawing.Point(20, 300);
            this.Controls.Add(monthCalendar);
        }
        private void InitializePictureBox()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(20, 500);
            pictureBox.Size = new System.Drawing.Size(100, 100);
            pictureBox.ImageLocation = "https://media.sproutsocial.com/uploads/2022/06/profile-picture.jpeg";
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(pictureBox);
        }
    }
}
