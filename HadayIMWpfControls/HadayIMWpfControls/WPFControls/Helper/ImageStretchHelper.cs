using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HadayIMWpfControls.WPFControls.Helper
{
    public class ImageStretchHelper : DependencyObject
    {
        public static string GetImageStretch(DependencyObject obj)
        {
            return (string)obj.GetValue(ImageStretchProperty);
        }

        public static void SetImageStretch(DependencyObject obj, string value)
        {
            obj.SetValue(ImageStretchProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageStretchProperty =
            DependencyProperty.RegisterAttached("ImageStretch", typeof(string), typeof(ImageStretchHelper), new FrameworkPropertyMetadata
            {
                //BindsTwoWayByDefault = false,
                PropertyChangedCallback = (obj, e) =>
                {
                    var image = (Image)obj;
                   var imageSoure =  new BitmapImage(new Uri(e.NewValue.ToString(), UriKind.RelativeOrAbsolute));
                    if (imageSoure.Width > image.MaxWidth || imageSoure.Height > image.MaxHeight)
                    {
                        image.Stretch = System.Windows.Media.Stretch.Uniform;
                    }
                    else
                    {
                        image.Stretch = System.Windows.Media.Stretch.None;
                    }
                }
            });
    }
}
