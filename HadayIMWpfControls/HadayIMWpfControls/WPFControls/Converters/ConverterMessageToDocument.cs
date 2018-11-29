using HadayIMWpfControls.WPFControls.Helper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HadayIMWpfControls.WPFControls
{
    public class ConverterMessageToDocument : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return null;
                //return FlowDocumentHelper.MessageToDocument(value.ToString());
            }
            catch (Exception)
            {
                return null;                
            }
          
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }


      


    }
}
