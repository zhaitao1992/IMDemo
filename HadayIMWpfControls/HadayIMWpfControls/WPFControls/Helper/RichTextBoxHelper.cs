using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace HadayIMWpfControls.WPFControls.Helper
{
    public class RichTextBoxHelper : DependencyObject
    {
        public static string GetDocumentXaml(DependencyObject obj)
        {
            return (string)obj.GetValue(DocumentXamlProperty);
        }
        public static void SetDocumentXaml(DependencyObject obj, string value)
        {
            obj.SetValue(DocumentXamlProperty, value);
        }
        public static readonly DependencyProperty DocumentXamlProperty =
          DependencyProperty.RegisterAttached(
            "DocumentXaml",
            typeof(string),
            typeof(RichTextBoxHelper),
            new FrameworkPropertyMetadata
            {
                BindsTwoWayByDefault = true,
                PropertyChangedCallback = (obj, e) =>
                {
                    var richTextBox = (RichTextBox)obj;
                    int width = FlowDocumentHelper.MessageToWidth(e.NewValue.ToString(), richTextBox.MaxWidth);
                    var temp = FlowDocumentHelper.MessageToDocument(e.NewValue.ToString());
                    richTextBox.Document = temp;
                    if (width < richTextBox.MaxWidth)
                    {                       
                        richTextBox.Width = width;
                    }
                   
                }
             
            });
    }
}
