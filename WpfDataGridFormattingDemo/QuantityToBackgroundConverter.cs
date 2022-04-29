﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Demo
{
    class QuantityToBackgroundConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int quantity)
            {
                if (quantity >= 100) return Brushes.White;
                if (quantity >= 10) return Brushes.WhiteSmoke;
                if (quantity >= 0) return Brushes.LightGray;
                return Brushes.White; //quantity should not be below 0
            }
            //value is not an integer. Do not throw an exception in the converter, but return something that is obviousl ywrong
            return Brushes.Yellow;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
