using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo
{
    public class QuantityToForegroundConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string s)
                if (int.TryParse(s, out var quantity))
                    if (quantity >= 0)
                        return Brushes.Black;
            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
