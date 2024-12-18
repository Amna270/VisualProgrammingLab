using System;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Media.Animation;

namespace lab_13_233533
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
        }

        private void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now; 
            UpdateTimeDisplay(currentTime); 
            Vibrate(); 
        }

        private void UpdateTimeDisplay(DateTime time)
        {
            TimeDisplay.Text = time.ToString("hh:mm:ss tt"); 
        }

        private void Vibrate()
        {
            
            var animation = new DoubleAnimation
            {
                From = 0,
                To = 5, 
                Duration = TimeSpan.FromMilliseconds(100), 
                AutoReverse = true,
                RepeatBehavior = new RepeatBehavior(5) 
            };

           
            this.BeginAnimation(Window.LeftProperty, animation);
        }
    }
}