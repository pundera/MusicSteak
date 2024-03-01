using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace MusicSteak.Converters
{
    internal class NoteColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var n = (int)values.First();
            var duration = (int)values.Last();
            var m = n % 12;
            bool isHalf = m == 1 || m == 3 || m == 6 || m == 8 || m == 10 || m == -11 || m == -9 || m == -6 || m == -4 || m == -2;
            if (duration == 0) return isHalf ? Brushes.DarkOliveGreen : Brushes.LightGreen;
            return duration switch
            {
                5 => new SolidColorBrush(Color.FromArgb(170, 250, 0, 255)),
                4 => new SolidColorBrush(Color.FromArgb(140, 210, 0, 255)),
                3 => new SolidColorBrush(Color.FromArgb(110, 170, 0, 255)),
                2 => new SolidColorBrush(Color.FromArgb(80, 140, 0, 255)),
                1 => new SolidColorBrush(Color.FromArgb(50, 110, 0, 255)),
                _ => new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))
            };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
