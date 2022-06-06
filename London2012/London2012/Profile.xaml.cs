using System.Windows;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace London2012
{
    public partial class Profile : PhoneApplicationPage
    {
        public Profile()
        {
            InitializeComponent();
            Color currentAccentColorHex = (Color)Application.Current.Resources["PhoneAccentColor"];
            Brush brush = new SolidColorBrush(currentAccentColorHex);

            // Write the current accent color.
            name.Foreground = brush;

           
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedItem", out selectedIndex))
            {
                int index = int.Parse(selectedIndex);
                DataContext = App.ViewModel.Items[index];
            }
        }
    }
}