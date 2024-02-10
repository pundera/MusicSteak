using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MusicSteak.Converters
{
    internal class VisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = (bool)value;
            return b ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (Visibility)value;
            return v.Equals(Visibility.Visible);
        }
    }
}
