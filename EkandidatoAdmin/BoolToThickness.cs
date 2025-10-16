using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace EkandidatoAdmin
{
    public class BoolToThickness : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
           => (value is bool b && b) ? new Thickness(3) : new Thickness(0);

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}