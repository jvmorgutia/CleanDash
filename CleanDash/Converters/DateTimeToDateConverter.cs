﻿using System;
using System.Globalization;
using Windows.UI.Xaml.Data;

namespace CleanDash.Converters
{
   public class DateTimeToDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            return ((DateTime)value).ToString("D");
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return DateTime.ParseExact(value.ToString(),"D",CultureInfo.CurrentCulture);
        }
    }
}
