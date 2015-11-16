using System;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using CleanDash.ViewModels;

namespace CleanDash
{
    public sealed partial class MainPage : Page
    {
        private readonly ApplicationView _view;

        public MainPage()
        {
            InitializeComponent();
            _view = ApplicationView.GetForCurrentView();
        }

        private void ToggleFullScreenClick(object sender, RoutedEventArgs e)
        {
            if (_view.IsFullScreen)
                _view.ExitFullScreenMode();
            else
                _view.TryEnterFullScreenMode();
        }
    }
}
