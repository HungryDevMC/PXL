using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PixelPass
{
    /// <summary>
    /// Interaction logic for CreateOrUpdateAccountInfoWindow.xaml
    /// </summary>
    public partial class CreateAccountInfoWindow : Window
    {
        private ListBox _accountListBox;
        private List<AccountInfo> _accountInfos;
        public CreateAccountInfoWindow(ListBox accountsListBox, List<AccountInfo> accountInfos)
        {
            InitializeComponent();
            _accountListBox = accountsListBox;
            _accountInfos = accountInfos;
            expirationDateTextBlock.Text = DateTime.Now.ToShortDateString();
        }

        private void ExpirationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (expirationDateTextBlock != null)
            {
                var slider = ((Slider) sender);
                var sliderValue = Convert.ToInt32(slider.Value);
                expirationDateTextBlock.Text =
                    DateTime.Now.AddDays(sliderValue).ToShortDateString();
            }
        }

        private void PasswordTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            passwordStrengthTextBlock.Text = PasswordValidator.CalculateStrength(passwordTextBox.Text).ToString();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var accountInfo = new AccountInfo
                {
                    Title = titleTextBox.Text,
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    Notes = notesTextBox.Text,
                    Expiration = Convert.ToDateTime(expirationDateTextBlock.Text)
                };
                _accountInfos.Add(accountInfo);
                _accountListBox.Items.Insert(0, new ListBoxItem {Content = accountInfo.Title});
                _accountListBox.Items.Refresh();
                Close();
            }
            catch(FormatException formatException)
            {
                System.Windows.MessageBox.Show(formatException.Message, "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}