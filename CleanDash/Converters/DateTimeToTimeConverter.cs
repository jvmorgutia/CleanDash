using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace CleanDash.Converters
{
    public class DateTimeToTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((DateTime)value).ToString("T");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DateTime.ParseExact(value.ToString(), "T", CultureInfo.CurrentCulture);
        }
    }
}
