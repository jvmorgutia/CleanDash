using System;
using Windows.UI.Xaml;
using GalaSoft.MvvmLight.Command;

namespace CleanDash.ViewModels
{
    public class MainPageViewModel:BaseViewModel
    {

        private DateTime _currentDateTime;
        public DateTime CurrentDateTime
        {
            get
            {
                return _currentDateTime;
            }
            set
            {
                _currentDateTime = value;
                OnPropertyChanged("CurrentDateTime");
            }
        }
        private double _displayBrightness;
        public double DisplayBrightness
        {
            get { return _displayBrightness; }
            set
            {
                _displayBrightness = value;
                OnPropertyChanged("DisplayBrightness");
            }
        }
        private bool _brightnessSliderIsVisible;
        public bool BrightnessSliderIsVisible
        {
            get
            {
                return _brightnessSliderIsVisible;
            }
            set
            {
                _brightnessSliderIsVisible = value;
                OnPropertyChanged("BrightnessSliderIsVisible");
            }
        }
        public SettingsMenuViewModel SettingsMenuViewModel { get; set; }
        public RelayCommand SettingsButtonClickCommand { get; set; }
        public RelayCommand BrightnessButtonClickCommand { get; set; }


        public MainPageViewModel()
        {
            UpdateDateTime(null,null);
            SettingsMenuViewModel = new SettingsMenuViewModel();
            SettingsButtonClickCommand = new RelayCommand(SettingsButtonClick);
            BrightnessButtonClickCommand = new RelayCommand(BrightnessButtonClick);

            DisplayBrightness = 75;
            SettingsMenuViewModel.IsVisible = false;
            BrightnessSliderIsVisible = false;

            var timer = new DispatcherTimer();
            timer.Tick += UpdateDateTime;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void SettingsButtonClick()
        {
            SettingsMenuViewModel.IsVisible = !SettingsMenuViewModel.IsVisible;
        }

        private void BrightnessButtonClick()
        {
            BrightnessSliderIsVisible = !BrightnessSliderIsVisible;
        }

        public void UpdateDateTime(object sender, object e)
        {
            CurrentDateTime = DateTime.Now;                    
        }        
    }
}