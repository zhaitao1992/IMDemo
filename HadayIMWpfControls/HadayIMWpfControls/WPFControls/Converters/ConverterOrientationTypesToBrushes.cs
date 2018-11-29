using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace HadayIMWpfControls.WPFControls
{
    public class ConverterOrientationTypesToBrushes : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BrushConverter brushConverter = new BrushConverter();
            //自己的色号
            Brush blule = (Brush)brushConverter.ConvertFromString("#009BDB");
            //其他的色号
            Brush green = (Brush)brushConverter.ConvertFromString("#54BB82");

            return  (OrientationTypes)value== OrientationTypes.Left ? green : blule;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
