// Type: Microsoft.Phone.Controls.PhoneApplicationPage
// Assembly: Microsoft.Phone, Version=7.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// Assembly location: C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\Silverlight\v4.0\Profile\WindowsPhone71\Microsoft.Phone.dll

using Microsoft.Phone.Shell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Microsoft.Phone.Controls
{
    public class PhoneApplicationPage : Page
    {
        public static readonly DependencyProperty SupportedOrientationsProperty;
        public static readonly DependencyProperty OrientationProperty;
        public static readonly DependencyProperty ApplicationBarProperty;
        public PhoneApplicationPage();
        public SupportedPageOrientation SupportedOrientations { get; set; }

        public PageOrientation Orientation { get; [EditorBrowsable(EditorBrowsableState.Never)]
        set; }

        public IApplicationBar ApplicationBar { get; set; }
        public IDictionary<string, object> State { get; }
        ~PhoneApplicationPage();
        protected virtual void OnOrientationChanged(OrientationChangedEventArgs e);
        protected virtual void OnBackKeyPress(CancelEventArgs e);
        protected virtual void OnRemovedFromJournal(JournalEntryRemovedEventArgs e);
        public event EventHandler<OrientationChangedEventArgs> BeginLayoutChanged;
        public event EventHandler<OrientationChangedEventArgs> OrientationChanged;
        public event EventHandler<CancelEventArgs> BackKeyPress;
    }
}
