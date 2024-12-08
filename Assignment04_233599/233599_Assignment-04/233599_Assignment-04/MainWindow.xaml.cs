using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace _233599_Assignment_04
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> Players { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Players = new ObservableCollection<string>();
            DataContext = this;
        }

        private void AddPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PlayerNameTextBox.Text))
            {
                Players.Add(PlayerNameTextBox.Text);
                PlayerNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a player name.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RemovePlayerButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayersListBox.SelectedItem != null)
            {
                Players.Remove(PlayersListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a player to remove.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }

    public class StringToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrWhiteSpace(value as string) ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
