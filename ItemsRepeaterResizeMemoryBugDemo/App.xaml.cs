using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace ItemsRepeaterResizeMemoryBugDemo
{
    sealed partial class App : Application
    {
        private Window? _window;

        public App()
        {
            this.InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var rootFrame = new Frame();
            rootFrame.NavigationFailed += OnNavigationFailed;

            _window = new Window
            {
                Title = "ItemsRepeaterResizeMemoryBugDemo",
                Content = rootFrame
            };

            rootFrame.Navigate(typeof(MainPage), e.Arguments);
            _window.Activate();
        }

        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new InvalidOperationException("Failed to load Page " + e.SourcePageType.FullName, e.Exception);
        }
    }
}
