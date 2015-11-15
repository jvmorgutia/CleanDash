using System;
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

        public SettingsMenuViewModel SettingsMenu { get; set; }
        public RelayCommand SettingsButtonClickCommand { get; set; }

        public MainPageViewModel()
        {
            UpdateDateTime(null,null);
            SettingsMenu = new SettingsMenuViewModel();
            SettingsButtonClickCommand = new RelayCommand(SettingsButtonClick);
            SettingsMenu.IsVisible = false;
        }

        private void SettingsButtonClick()
        {
            SettingsMenu.IsVisible = !SettingsMenu.IsVisible;
        }

        public void UpdateDateTime(object sender, object e)
        {
            CurrentDateTime = DateTime.Now;                    
        }        
    }
}