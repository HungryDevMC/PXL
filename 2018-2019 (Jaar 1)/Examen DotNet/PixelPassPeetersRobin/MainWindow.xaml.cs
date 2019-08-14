using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PixelPass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IAccountInfoCollection _accountInfoCollection;
        private AccountInfo _currentAccountInfo;
        private DispatcherTimer _passwordTimer;
        private int _steps;
        private Brush _badBrush;
        private Brush _goodBrush;

        public MainWindow()
        {
            InitializeComponent();

            _steps = 0;
            _badBrush = new SolidColorBrush(Colors.LightCoral);
            _goodBrush = new SolidColorBrush(Colors.White);

            _passwordTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _passwordTimer.Tick += PasswordTimer_Tick;
        }

        private void OpenItem_Click(object sender, RoutedEventArgs e)
        {
            accountInfoListBox.Items.Clear();
            _currentAccountInfo = null;
            newAccountInfoButton.IsEnabled = false;
            copyButton.IsEnabled = false;

            var folderBrowser = new System.Windows.Forms.OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            var dialogResult = folderBrowser.ShowDialog();
            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    _accountInfoCollection = AccountInfoCollectionReader.Read(folderBrowser.FileName);
                    Title = $"PixelPass - {_accountInfoCollection.Name}";

                    // Add list box items
                    _accountInfoCollection.AccountInfos.ForEach(account => accountInfoListBox.Items.Insert(0,
                        new ListBoxItem
                        {
                            Content = account.Title
                        }
                    ));
                    newAccountInfoButton.IsEnabled = true;
                }
                catch (ParseException parseException)
                {
                    System.Windows.MessageBox.Show(parseException.Message, "Error", System.Windows.MessageBoxButton.OK ,System.Windows.MessageBoxImage.Error);
                }
            }
        }

        private void AccountInfoListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedListBoxItem = ((ListBoxItem) ((System.Windows.Controls.ListBox) sender).SelectedItem);
            if (selectedListBoxItem != null)
            {
                _currentAccountInfo =
                    _accountInfoCollection.AccountInfos.Find(account =>
                        account.Title == selectedListBoxItem.Content);

                titleTextBlock.Text = _currentAccountInfo.Title;
                usernameTextBlock.Text = _currentAccountInfo.Username;
                notesTextBlock.Text = _currentAccountInfo.Notes;
                expirationTextBlock.Text = _currentAccountInfo.Expiration.ToShortDateString();
                if (_currentAccountInfo.IsExpired)
                {
                    copyButton.IsEnabled = false;
                    detailsCanvas.Background = _badBrush;
                }
                else
                {
                    copyButton.IsEnabled = true;
                    detailsCanvas.Background = _goodBrush;
                }
            }
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            _steps = 0;
            expirationProgressBar.Value = 5;
            _passwordTimer.Start();
            System.Windows.Clipboard.SetText(_currentAccountInfo.Password);
        }

        private void PasswordTimer_Tick(object sender, EventArgs e)
        {
            _steps++;

            expirationProgressBar.Value = 5 - _steps;

            if (_steps == 5)
            {
                System.Windows.Clipboard.Clear();
            }
        }

        private void NewAccountInfoButton_Click(object sender, RoutedEventArgs e)
        {
            var createAccountWindow =
                new CreateAccountInfoWindow(accountInfoListBox, _accountInfoCollection.AccountInfos);
            createAccountWindow.ShowDialog();
        }
    }
}