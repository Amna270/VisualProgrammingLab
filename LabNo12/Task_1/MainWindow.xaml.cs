using System.Collections.Generic;
using System.Windows;

namespace OrderApp
{
    public partial class MainWindow : Window
    {
        private List<string> addresses = new List<string>
        {
            "123 Main St, City A",
            "456 Elm St, City B",
            "789 Oak St, City C"
        };

        public MainWindow()
        {
            InitializeComponent();
            AddressComboBox.ItemsSource = addresses;
        }

        private void ChangeAddress_Click(object sender, RoutedEventArgs e)
        {
            string selectedAddress = AddressComboBox.SelectedItem as string;
            if (selectedAddress != null)
            {
                MessageBoxResult result = MessageBox.Show("Do you want to change the selected address?", "Change Address", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    // Logic to change the address or add a new one
                    ResultTextBlock.Text = "Address changed successfully!";
                }
            }
            else
            {
                MessageBox.Show("Please select an address.");
            }
        }
    }
}