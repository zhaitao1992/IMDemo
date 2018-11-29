using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace HadayIMWpfControls.WPFControls
{
    public class ConverterStringToBrushes : TypeConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return Brushes.White;
            try
            {
                BrushConverter brushConverter = new BrushConverter();
                return  (Brush)brushConverter.ConvertFromString(value.ToString());            
            }
            catch (Exception ex)
            {
                return Brushes.White;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
