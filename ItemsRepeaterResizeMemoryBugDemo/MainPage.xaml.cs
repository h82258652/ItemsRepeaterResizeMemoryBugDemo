using System;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.UI.Xaml.Controls;

namespace ItemsRepeaterResizeMemoryBugDemo
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Repeater.ItemsSource = new ObservableCollection<object>(Enumerable.Range(0, 100).Select(temp => Guid.NewGuid().ToString()).ToList());
        }
    }
}
