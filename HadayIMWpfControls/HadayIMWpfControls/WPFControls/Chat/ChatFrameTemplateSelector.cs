using HadayIMWpfControls.WPFControls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace HadayIMWpfControls.WPFControls
{
    public class ChatListTemplateSelector: DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var fe = container as FrameworkElement;
            var messageModel = item as MessageModel;
            
            if (messageModel != null && fe != null)
            {
                if (messageModel.OrientationType == OrientationTypes.Left)
                {
                    switch (messageModel.MessageType)
                    {
                        case MessageTypes.Text:
                            return fe.FindResource("Text") as DataTemplate;
                        case MessageTypes.RichText:
                            return fe.FindResource("RichText") as DataTemplate;
                        case MessageTypes.Image:
                            return fe.FindResource("Image") as DataTemplate;
                        case MessageTypes.File:
                            return fe.FindResource("File") as DataTemplate;
                        case MessageTypes.Quote:
                            return fe.FindResource("Quote") as DataTemplate;
                        case MessageTypes.SystemMessage:
                            return fe.FindResource("SystemMessage") as DataTemplate;
                        case MessageTypes.SystemMessageWithOutBubble:
                            return fe.FindResource("SystemMessageWithOutBubble") as DataTemplate;
                        default:
                            break;
                    }
                }
                else
                {
                    switch (messageModel.MessageType)
                    {
                        case MessageTypes.Text:
                            return fe.FindResource("Text_Right") as DataTemplate;
                        case MessageTypes.RichText:
                            return fe.FindResource("RichText_Right") as DataTemplate;
                        case MessageTypes.Image:
                            return fe.FindResource("Image_Right") as DataTemplate;
                        case MessageTypes.File:
                            return fe.FindResource("File_Right") as DataTemplate;
                        case MessageTypes.Quote:
                            return fe.FindResource("Quote_Right") as DataTemplate;
                        case MessageTypes.SystemMessage:
                            return fe.FindResource("SystemMessage") as DataTemplate;
                        case MessageTypes.SystemMessageWithOutBubble:
                            return fe.FindResource("SystemMessageWithOutBubble") as DataTemplate;
                        default:
                            break;
                    }

                }
            }
            return null;
        }



    }
    public class ChatHistoryListTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var fe = container as FrameworkElement;
            var messageModel = item as MessageModel;

            if (messageModel != null && fe != null)
            {
                switch (messageModel.MessageType)
                {
                    case MessageTypes.Text:
                    case MessageTypes.Quote:
                        return fe.FindResource("Text") as DataTemplate;
                    case MessageTypes.RichText:
                        return fe.FindResource("RichText") as DataTemplate;
                    case MessageTypes.Image:
                        return fe.FindResource("Image") as DataTemplate;
                    case MessageTypes.File:
                        return fe.FindResource("File") as DataTemplate;                     
                    case MessageTypes.SystemMessage:
                    case MessageTypes.SystemMessageWithOutBubble:
                        return fe.FindResource("SystemMessage") as DataTemplate;                
                    default:
                        break;
                }                
            }
            return null;
        }



    }

}
