using System;
using System.Globalization;
using Xamarin.Forms;

namespace AceConstructionCalculator.Converters
{
    public class ReverseBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueAsBool = (bool)value;
            return !valueAsBool;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valueAsBool = (bool)value;
            return !valueAsBool;
        }
    }
}
