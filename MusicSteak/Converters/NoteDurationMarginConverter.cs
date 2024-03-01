using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace MusicSteak.Converters
{
    internal class NoteDurationMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var duration = (int)value;
            if (duration == 0) return new Thickness(0);
            return duration switch
            {
                5 => new Thickness(0, 0, 0, 0),
                4 => new Thickness(0, 2, 0, 0),
                3 => new Thickness(0, 4, 0, 0),
                2 => new Thickness(0, 6, 0, 0),
                1 => new Thickness(0, 8, 0, 0),
                _ => throw new NotImplementedException(),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
