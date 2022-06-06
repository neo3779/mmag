using System.Windows.Media;
using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Controls;

namespace London2012
{
    public partial class teamGBFinder : PhoneApplicationPage
    {

        // Constructor
        public teamGBFinder()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);

            // Write the current accent color.
            PageTitle.Foreground = brush;
            
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Handle selection changed on ListBox
        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // If selected index is -1 (no selection) do nothing
            if (MainListBox.SelectedIndex == -1)
                return;

            // Navigate to the new page
            NavigationService.Navigate(new Uri("/Profile.xaml?selectedItem=" + MainListBox.SelectedIndex, UriKind.Relative));

            // Reset selected index to -1 (no selection)
            MainListBox.SelectedIndex = -1;
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

    }
}