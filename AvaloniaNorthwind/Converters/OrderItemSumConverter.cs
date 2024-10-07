using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace AvaloniaNorthwind.Converters
{
    internal class OrderItemSumConverter : IMultiValueConverter
    {
        public object? Convert(IList<object?> values, Type targetType, object? parameter, CultureInfo culture)
        {
            if (values.Count == 3
            && values[0] is decimal unitPrice
            && values[1] is int quantity
            && values[2] is decimal discount)
            {
                return unitPrice * quantity - discount;
            }
            else
            {
                return 0;
            };
        }
    }
}
