using System.Globalization;
using System.Windows.Data;

namespace MusicSteak.Converters
{
    internal class NoteDurationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var duration = (int)value;
            if (duration == 0) return 16;
            return duration switch
            {
                5 => 16,
                4 => 14,
                3 => 12,
                2 => 10,
                1 => 8,
                _ => throw new NotImplementedException(),
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
