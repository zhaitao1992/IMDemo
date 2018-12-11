using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WpfAnimatedGif;

namespace HadayIMWpfControls.WPFControls.Helper
{
    public class FlowDocumentHelper
    {
        //默认表情地址
        public static string imageBasePath = @"D:/";

        public static FlowDocument MessageToDocument(string message,int imageMaxWidth=100)
        {
            FlowDocument flowDocument = new FlowDocument();
            if (message.Contains("[&:") && message.Contains("]"))
            {
                
                char[] chars = message.ToCharArray();
                Paragraph paragraph = new Paragraph();
                Run run = new Run();             
                for (int i = 0; i < chars.Length; i++)
                {
                    char c = chars[i];
                    if (i + 2 < chars.Length && chars[i] == '[' && chars[i + 1] == '&' && chars[i + 2] == ':')
                    {
                        int f = message.IndexOf(']', i);
                        string str = message.Substring(i + 3, f - i - 3);
                        string imagePath = imageBasePath + str + ".jpg";
                        if (!File.Exists(imagePath))
                        {
                            imagePath = imageBasePath + str + ".gif";
                        }
                        try
                        {
                            if (File.Exists(imagePath))
                            {
                                var imageTemp = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                                //MediaElement image = new MediaElement() { Source = new Uri(imagePath, UriKind.Absolute), MaxWidth = imageMaxWidth, MaxHeight = imageMaxWidth, Margin = new Thickness(2, 0, 2, 0) };
                                //image.MediaEnded += (o, e) =>
                                //{
                                //    ((MediaElement)o).Position = ((MediaElement)o).Position.Add(TimeSpan.FromMilliseconds(1));
                                //};

                                System.Windows.Controls.Image image = new System.Windows.Controls.Image() { MaxWidth = imageMaxWidth, MaxHeight = imageMaxWidth, Margin = new Thickness(2, 0, 2, 0) };
                                if (imageTemp.Width <= imageMaxWidth && imageTemp.Height <= imageMaxWidth)
                                {
                                    image.Stretch = Stretch.None;
                                }
                                ImageBehavior.SetAnimatedSource(image , imageTemp);                              
                                paragraph.Inlines.Add(new InlineUIContainer(image));                               
                                i = f;
                            }
                            else
                            {                              
                                paragraph.Inlines.Add(new TextBlock() { Text = c.ToString() });
                            }
                        }
                        catch (Exception)
                        {

                        }                       
                    }
                    else
                    {                      
                        paragraph.Inlines.Add(new TextBlock() { Text = c.ToString()});
                    }
                }              
                flowDocument.Blocks.Add(paragraph);
            }
            else
            {
                Paragraph paragraph= new Paragraph();          
                char[] chars = message.ToCharArray();
                foreach (var c in chars)
                {
                    paragraph.Inlines.Add(new TextBlock() { Text = c.ToString() });
                }
              
                flowDocument.Blocks.Add(paragraph);
            }

            flowDocument.FontSize = 12;
            flowDocument.FontFamily = new System.Windows.Media.FontFamily("Microsoft YaHei");          
            return flowDocument;
        }

        public static int MessageToWidth(string message,double maxFlowDocumentWidth=300)
        {
            FlowDocument flowDocument = new FlowDocument();
            double imageWidth = 0;
            if (message.Contains("[&:") && message.Contains("]"))
            {
                int maxWidth = 100;
                char[] chars = message.ToCharArray();
                Paragraph paragraph = new Paragraph();
                Run run = new Run();
                for (int i = 0; i < chars.Length; i++)
                {
                    char c = chars[i];
                    if (i + 2 < chars.Length && chars[i] == '[' && chars[i + 1] == '&' && chars[i + 2] == ':')
                    {
                        int f = message.IndexOf(']', i);
                        string str = message.Substring(i + 3, f - i - 3);
                        string imagePath = imageBasePath + str + ".jpg";
                        if (!File.Exists(imagePath))
                        {
                            imagePath = imageBasePath + str + ".gif";
                        }
                        try
                        {
                            if (File.Exists(imagePath))
                            {
                                var imageTemp = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                                System.Windows.Controls.Image image = new System.Windows.Controls.Image() { Source = imageTemp, MaxWidth = maxWidth, MaxHeight = maxWidth, Margin = new Thickness(2, 0, 2, 0) };
                                if (imageTemp.Width <= maxWidth && imageTemp.Height <= maxWidth)
                                {
                                    image.Stretch = Stretch.None;
                                    //加上margin
                                    imageWidth +=imageTemp.Width + image.Margin.Left + image.Margin.Right;
                                }
                                else
                                {
                                    imageWidth += maxWidth;
                                }
                                paragraph.Inlines.Add(new InlineUIContainer(image));
                                i = f;
                            }
                            else
                            {
                                paragraph.Inlines.Add(new Run(c.ToString()));
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }
                    else
                    {
                        paragraph.Inlines.Add(new Run() { Text = c.ToString() });
                    }
                }

                flowDocument.Blocks.Add(paragraph);
            }
            else
            {
                flowDocument.Blocks.Add(new Paragraph(new Run(message)));
            }

            flowDocument.FontSize = 12;
            flowDocument.FontFamily = new System.Windows.Media.FontFamily("Microsoft YaHei");

            return  (int)CalcMessageWidth(flowDocument, imageWidth, maxFlowDocumentWidth);
  
        }

        public static double CalcMessageWidth(FlowDocument t,double imageWidth, double w)
        {
            TextRange range = new TextRange(t.ContentStart, t.ContentEnd);
            var text = range.Text;
            var formatText = GetFormattedText(t);        
            return Math.Min(formatText.WidthIncludingTrailingWhitespace+ imageWidth + 20 , w);
        }

        public static FormattedText GetFormattedText(FlowDocument doc)
        {
            var output = new FormattedText(
                GetText(doc),
                System.Globalization.CultureInfo.CurrentCulture,
                doc.FlowDirection,
                new Typeface(doc.FontFamily, doc.FontStyle, doc.FontWeight, doc.FontStretch),
                doc.FontSize,
                doc.Foreground);
            int offset = 0;

            foreach (TextElement textElement in GetRunsAndParagraphs(doc))
            {
                var run = textElement as Run;

                if (run != null)
                {
                    int count = run.Text.Length;

                    output.SetFontFamily(run.FontFamily, offset, count);
                    output.SetFontSize(run.FontSize, offset, count);
                    output.SetFontStretch(run.FontStretch, offset, count);
                    output.SetFontStyle(run.FontStyle, offset, count);
                    output.SetFontWeight(run.FontWeight, offset, count);
                    output.SetForegroundBrush(run.Foreground, offset, count);
                    output.SetTextDecorations(run.TextDecorations, offset, count);

                    offset += count;
                }
                else
                {
                    offset += Environment.NewLine.Length;
                }
            }
            return output;
        }

        private static string GetText(FlowDocument doc)
        {
            var sb = new StringBuilder();
            foreach (TextElement text in GetRunsAndParagraphs(doc))
            {
                var run = text as Run;
                sb.Append(run == null ? Environment.NewLine : run.Text);
            }
            return sb.ToString();
        }

        private static IEnumerable<TextElement> GetRunsAndParagraphs(FlowDocument doc)
        {
            for (TextPointer position = doc.ContentStart;
                position != null && position.CompareTo(doc.ContentEnd) <= 0;
                position = position.GetNextContextPosition(LogicalDirection.Forward))
            {
                if (position.GetPointerContext(LogicalDirection.Forward) == TextPointerContext.ElementEnd)
                {
                    var run = position.Parent as Run;

                    if (run != null)
                    {
                        yield return run;
                    }
                    else
                    {
                        var para = position.Parent as Paragraph;

                        if (para != null)
                        {
                            yield return para;
                        }
                        else
                        {
                            var lineBreak = position.Parent as LineBreak;

                            if (lineBreak != null)
                            {
                                yield return lineBreak;
                            }
                        }
                    }
                }
            }
        }
        

    }
}
