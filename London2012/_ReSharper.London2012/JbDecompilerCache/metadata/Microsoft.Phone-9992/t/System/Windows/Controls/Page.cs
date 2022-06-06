// Type: System.Windows.Controls.Page
// Assembly: Microsoft.Phone, Version=7.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\Silverlight\v4.0\Profile\WindowsPhone71\Microsoft.Phone.dll

using System.Windows.Navigation;

namespace System.Windows.Controls
{
    public class Page : UserControl
    {
        public NavigationContext NavigationContext { get; }
        public NavigationService NavigationService { get; }
        public string Title { get; set; }
        public NavigationCacheMode NavigationCacheMode { get; internal set; }
        protected virtual void OnFragmentNavigation(FragmentNavigationEventArgs e);
        protected virtual void OnNavigatedTo(NavigationEventArgs e);
        protected virtual void OnNavigatingFrom(NavigatingCancelEventArgs e);
        protected virtual void OnNavigatedFrom(NavigationEventArgs e);
    }
}
