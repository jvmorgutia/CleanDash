using GalaSoft.MvvmLight.Command;

namespace CleanDash.ViewModels
{
    public class SettingsMenuViewModel : BaseViewModel
    {
        private int _timeFontSize;
        public int TimeFontSize
        {
            get
            {
                return _timeFontSize;
            }
            set
            {
                _timeFontSize = value;
                OnPropertyChanged("TimeFontSize");
            }
        }
        private int _dateFontSize;

        public int DateFontSize
        {
            get
            {
                return _dateFontSize;
            }
            set
            {
                _dateFontSize = value;
                OnPropertyChanged("DateFontSize");
            }
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get { return _isVisible; }
            set
            {
                _isVisible = value;
                OnPropertyChanged("IsVisible");
            }
        }

        public RelayCommand CloseMenuClickCommand { get; set; }

        public SettingsMenuViewModel()
        {
            CloseMenuClickCommand = new RelayCommand(() =>
            {
                IsVisible = false;
            });
            TimeFontSize = 120;
            DateFontSize = 30;
        }
    }
}
