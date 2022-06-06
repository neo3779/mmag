using System;
using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace London2012
{


    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);

            // Write the current accent color.
            PageTitle.Foreground = brush;
        }

        private void btnCountdown_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Countdown.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnEventFinder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventFinder.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnTeamGB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TeamGBFinder.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}