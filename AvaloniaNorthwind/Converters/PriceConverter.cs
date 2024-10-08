using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AvaloniaNorthwind.Converters
{
    internal class PriceConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            float price = System.Convert.ToSingle(value);
            return price.ToString("C", new CultureInfo("ru-RU"));
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return 0.0f;
        }
    }
}
