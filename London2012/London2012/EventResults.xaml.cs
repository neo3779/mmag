using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace London2012
{
    public partial class EventResults : PhoneApplicationPage
    {
        EventInfo ev = new EventInfo();
        public EventResults()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);

            // Write the current accent color.
            PageTitle.Foreground = brush;

        }
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedDate = "";
            string selectedVenue = "";
            string selectedEvent = "";

            NavigationContext.QueryString.TryGetValue("selectedDate", out selectedDate);
            NavigationContext.QueryString.TryGetValue("selectedVenue", out selectedVenue);
            NavigationContext.QueryString.TryGetValue("selectedEvent", out selectedEvent);

            string[,] searchResults;

           searchResults = ev.Search(selectedDate, selectedEvent, selectedVenue);

            if(searchResults[0,0]==null)
            {
                listBox1.Items.Add("Sorry, no events were found." + Environment.NewLine + "Please go back and try again.");
            }
            else
            {
                for(int i=0; i<20; i++)
                {
                    if(searchResults[i,0]!=null)
                    {
                        listBox1.Items.Add("Date: " + searchResults[i, 0] + Environment.NewLine + "Time: " + searchResults[i, 3] + Environment.NewLine + "Event: " + searchResults[i, 1] + Environment.NewLine + "Venue: " + searchResults[i, 2] + Environment.NewLine);
                    }
                }
            }
            

        }

    }
}