using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo
{
    public class IsObsoleteToTextDecorationsConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b && b)
            {
                var redStrikthroughTextDecoration = TextDecorations.Strikethrough.CloneCurrentValue();
                redStrikthroughTextDecoration[0].Pen = new Pen { Brush = Brushes.Red, Thickness = 3 };
                return redStrikthroughTextDecoration;
            }
            return new TextDecorationCollection();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
