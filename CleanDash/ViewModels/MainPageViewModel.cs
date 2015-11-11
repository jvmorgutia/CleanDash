using System;
using System.Threading;

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

        public MainPageViewModel()
        {
            UpdateDateTime(null,null);
            TimeFontSize = 100;
        }

        public void UpdateDateTime(object sender, object e)
        {
            CurrentDateTime = DateTime.Now;                    
        }        
    }
}