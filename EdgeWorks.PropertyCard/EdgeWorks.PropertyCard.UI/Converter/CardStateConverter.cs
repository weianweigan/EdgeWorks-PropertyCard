using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace EdgeWorks.PropertyCard.UI.Converter;

public sealed class CardStateConverter : IValueConverter
{
    public object Convert(
        object value, 
        Type targetType, 
        object parameter, 
        CultureInfo culture)
    {
        return (CardState)value == (CardState)parameter ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(
        object value, 
        Type targetType, 
        object parameter, 
        CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
