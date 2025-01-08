using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Lab_Final
{
    public class Student
    {
        public string name { get; set; }
        public string subject { get; set; }
        public string grade { get; set; }
        public double marks { get; set; }
        public double percentage { get; set; }

        public override string ToString()
        {
            //  return base.ToString();
            return $" Name : {name}        Subject : {subject}        Grade : {grade}       Marks : {marks}      Attendence : {percentage}";
        }

    }
    public partial class MainWindow : Window
    {
        private string connectionString = "DataSource=C:\\Users\\noora\\OneDrive\\Documents;Version=3";
        private List<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            students = new List<Student>();
            DataGrid dataGrid = new DataGrid();
            dataGrid.ItemsSource = students;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student 
            {
                name = text_box1.Text,
                grade = text_box2.Text,
                subject = text_box3.Text,
                marks = double.Parse(text_box4.Text),
                percentage = double.Parse(text_box5.Text) 
            });
            Clear();
            UpdateStudent();
        }

        public void Clear()
        {
            text_box1.Clear();
            text_box2.Clear();
            text_box3.Clear();
            text_box4.Clear();
            text_box5.Clear();
        }

        public void UpdateStudent()
        {
            std_list.Items.Clear();
            foreach(var std in students)
            {
                std_list.Items.Add(std);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (std_list.SelectedIndex >= 0)
            {
                students.RemoveAt(std_list.SelectedIndex);
                UpdateStudent();
            }
            else
            {
                MessageBox.Show("Please Select a value");
            }
        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            if (std_list.SelectedIndex >= 0)
            {
                var selected_one = students[std_list.SelectedIndex];
                selected_one.name = text_box1.Text;
                selected_one.grade = text_box2.Text;
                selected_one.subject = text_box3.Text;
                selected_one.marks = double.Parse(text_box4.Text);
                selected_one.percentage = double.Parse(text_box5.Text);
                Clear();
                UpdateStudent();
            }
            else
            {
                MessageBox.Show("Please Select a value");
            }
        }
    }
}
