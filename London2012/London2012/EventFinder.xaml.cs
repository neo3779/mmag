using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace London2012
{
    public partial class EventFinder : PhoneApplicationPage
    {
        private EventInfo info;
        public EventFinder()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);
            
            // Write the current accent color.
            //txtDate.Foreground = brush;
            //txtEvent.Foreground = brush;
            //txtVenue.Foreground = brush;
            PageTitle.Foreground = brush;
            info = new EventInfo();

            listOfDates.Items.Add("Any Date");
            listBox2.Items.Add("Any Event");
            listBox3.Items.Add("Any Venue");

            for (int i = 0; i < info.GetDates().Length; i++)
            {
                listOfDates.Items.Add(info.GetDates()[i]);
            }
            for (int i = 0; i < info.GetEvents().Length; i++)
            {
                listBox2.Items.Add(info.GetEvents()[i]);

            }
            for (int i = 0; i < info.GetVenue().Length; i++)
            {
                listBox3.Items.Add(info.GetVenue()[i]);

            }
            
        }


        private void btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/EventResults.xaml?selectedDate=" + listOfDates.SelectedItem + "&selectedEvent=" + listBox2.SelectedItem + "&selectedVenue=" + listBox3.SelectedItem, UriKind.Relative));
        }
    }
}