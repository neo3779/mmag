using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Phone.Controls;

namespace London2012
{
    public partial class Countdown : PhoneApplicationPage
    {
        DateTime current = DateTime.Now;
        DateTime startLondon = new DateTime(2012, 07, 27, 19, 30, 00);
        TimeSpan timeSpan;

        private string text;
        DispatcherTimer dt = new DispatcherTimer();

        public Countdown()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);

            // Write the current accent color.
            PageTitle.Foreground = brush;

            updateCountdown();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Start();
       }

        void dt_Tick(object sender, EventArgs e)
        {
            updateCountdown();
        }


        private void updateCountdown()
        {
            current = DateTime.Now;
            timeSpan = startLondon.Subtract(current);
            if (timeSpan.TotalSeconds > 0)
            {
                text = "Days: " + timeSpan.Days.ToString() +
                       " Hours: " + timeSpan.Hours.ToString()
                       + Environment.NewLine + "Mins: " +
                       timeSpan.Minutes.ToString() + " Secs: " +
                       timeSpan.Seconds.ToString();
                countdown.Text = text;
            }
            else
            {
                countdown.Text = "The games have begun!";
            }
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            video.Play();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            video.Pause();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            video.Stop();
        }

    }
}