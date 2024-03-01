using System.Globalization;
using System.Windows.Data;

namespace MusicSteak.Converters
{
    internal class NoteConverter : IValueConverter
    {
        readonly Dictionary<int, string> _notes = new([
            new (24, "c1"),
            new (23, "h"),
            new (22, "a#"),
            new (21, "a"),
            new (20, "g#"),
            new (19, "g"),
            new (18, "f#"),
            new (17, "f"),
            new (16, "e"),
            new (15, "d#"),
            new (14, "d"),
            new (13, "c#"),
            new (12, "c"),
            new (11, "H"),
            new (10, "A#"),
            new (9, "A"),
            new (8, "G#"),
            new (7, "G"),
            new (6, "F#"),
            new (5, "F"),
            new (4, "E"),
            new (3, "D#"),
            new (2, "D"),
            new (1, "C#"),
            new (0, "C"),
            new (-1, "H1"),
            new (-2, "A1#"),
            new (-3, "A1"),
            new (-4, "G1#"),
            new (-5, "G1"),
            new (-6, "F1#"),
            new (-7, "F1"),
            new (-8, "E1"),
            new (-9, "D1#"),
            new (-10, "D1"),
            new (-11, "C1#"),
            new (-12, "C1"),
            ]); 

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var b = (int)value;
            return _notes[b];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var v = (string)value;
            return _notes.Keys.FirstOrDefault(x => x.Equals(v));
        }
    }
}
