using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace MAUIButtonBackgroudColorBug.Converters
{
    class FromBoolToCustomValueConverter : IValueConverter
    {
        public object ValueIfTrue { get; set; }
        public object ValueIfFalse { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? ValueIfTrue : ValueIfFalse;
            }

            return ValueIfFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
