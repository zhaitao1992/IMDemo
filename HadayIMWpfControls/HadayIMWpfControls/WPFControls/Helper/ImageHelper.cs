using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

namespace HadayIMWpfControls.WPFControls.Helper
{
    public class ImageHelper
    {
        private static BitmapImage ByteArrayToBitmapImage(byte[] byteArray)
        {
            BitmapImage bmp = null;
            try
            {
                var ms = new System.IO.MemoryStream(byteArray);
                bmp = new BitmapImage();
                bmp.BeginInit();
                bmp.CacheOption = BitmapCacheOption.OnLoad;
                bmp.StreamSource = ms;
                bmp.EndInit();
                bmp.Freeze();
                ms.Close();
            }
            catch
            {
                bmp = null;
            }
            return bmp;
        }
    }
}
