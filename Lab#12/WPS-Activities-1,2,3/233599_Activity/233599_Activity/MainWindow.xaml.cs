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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _233599_Activity
{
    public partial class MainWindow : Window
    {
        // Declare the DispatcherTimer as readonly
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            // Initialize and start the timer
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1) // Update every second
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public static readonly DependencyProperty CurrentTimeProperty = DependencyProperty.Register(
            "CurrentTime",
            typeof(DateTime),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(
                DateTime.Now,
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                OnCurrentTimePropertyChanged,
                OnCoerceCurrentTimeProperty)
        );

        public DateTime CurrentTime
        {
            get { return (DateTime)GetValue(CurrentTimeProperty); }
            set { SetValue(CurrentTimeProperty, value); }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTime = DateTime.Now; // Update the time every tick
        }

        private static void OnCurrentTimePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is MainWindow window)
            {
                DateTime oldValue = (DateTime)e.OldValue;
                DateTime newValue = (DateTime)e.NewValue;

                Console.WriteLine($"CurrentTime changed from {oldValue} to {newValue}");
            }
        }

        private static object OnCoerceCurrentTimeProperty(DependencyObject d, object baseValue)
        {
            if (baseValue is DateTime newValue)
            {
                if (newValue > DateTime.Now)
                {
                    Console.WriteLine("Attempted to set CurrentTime to a future value. Coercing to DateTime.Now.");
                    return DateTime.Now;
                }
            }

            return baseValue;
        }

        // Define the missing event handler
        private void UpdateTimeButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentTime = DateTime.Now; // Manually update CurrentTime
        }
    }
}