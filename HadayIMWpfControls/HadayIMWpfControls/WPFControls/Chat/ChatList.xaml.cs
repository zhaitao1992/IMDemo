using HadayIMWpfControls.WPFControls.Helper;
using HadayIMWpfControls.WPFControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HadayIMWpfControls.WPFControls
{
    /// <summary>
    /// ChatControl.xaml 的交互逻辑
    /// </summary>
    public partial class ChatList : UserControl
    {
        private int messageCount = 0;
        public ChatList()
        {
            InitializeComponent();
            ((INotifyCollectionChanged)listBox.Items).CollectionChanged += ChatList_CollectionChanged; 
        }

        #region private event
        private void ChatList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                if (e.Action == NotifyCollectionChangedAction.Add)
                {

                    var item = sender as ItemCollection;
                    if (item == null) return;
                    if (e.NewStartingIndex == item.Count - 1)
                    {
                        var temp = Helper.VisualTreeHelperCstm.GetChildObjects<ScrollViewer>(listBox, "scrollViewer")?.First();
                        if (temp == null) return;
                        if (temp.ViewportHeight < temp.ExtentHeight && temp.ViewportHeight + temp.VerticalOffset != temp.ExtentHeight)
                        {
                            var messageList = e.NewItems.SyncRoot as Object[];
                            var message = messageList[0] as MessageModel;
                            if (message != null & message.OrientationType != OrientationTypes.Right)
                            {
                                HaveNewMassage();
                            }
                        }
                        else
                        {
                            temp.ScrollToEnd();

                        }
                    }

                }
              
            }
            catch (Exception)
            {
                 
            }
        }      
        public delegate void CopyHanler(object o);
        /// <summary>
        /// 右键-复制
        /// </summary>
        public event CopyHanler CopyEvent;
        public delegate void ReferenceHanler(object o);
        /// <summary>
        /// 右键-回复消息
        /// </summary>
        public event ReferenceHanler ReferenceEvent;
        public delegate void UndoHanler(object o);
        /// <summary>
        /// 右键-撤销消息
        /// </summary>
        public event UndoHanler UndoEvent;
        public delegate void TranspondHanler(object o);
        /// <summary>
        /// 右键-转发消息
        /// </summary>
        public event TranspondHanler TranspondMeaageEvent;
        public delegate void SaveAsHanler(object o);
        /// <summary>
        /// 右键-转发消息
        /// </summary>
        public event SaveAsHanler SaveAsEvent;

        private void copy_Click(object sender, RoutedEventArgs e)
        {
           var temp= sender as MenuItem;
           var temp2= temp?.DataContext;
            if (CopyEvent != null && temp2 != null)
                CopyEvent(temp2);
     
        }

        private void reference_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as MenuItem;
            var temp2 = temp?.DataContext;
            if (ReferenceEvent != null && temp2 != null)
                ReferenceEvent(temp2);
        }

        private void undo_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as MenuItem;
            var temp2 = temp?.DataContext;
            if (UndoEvent != null && temp2 != null)
                UndoEvent(temp2);
        }

        private void transpond_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as MenuItem;
            var temp2 = temp?.DataContext;
            if (TranspondMeaageEvent != null && temp2 != null)
                TranspondMeaageEvent(temp2);
        }
        private void saveAs_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as MenuItem;
            var temp2 = temp?.DataContext;
            if (SaveAsEvent != null && temp2 != null)
                SaveAsEvent(temp2);
        }

        private void headImageLeft_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {

                var img = sender as Image;
                Popup popup = new Popup() { };
                popup.PlacementTarget = img;
                popup.Placement = PlacementMode.Left;
                popup.AllowsTransparency = true;
                popup.StaysOpen = false;
                UserInfo userInfo = new UserInfo() { DataContext = ((MessageModel)img.DataContext).UserInfo };
                popup.Child = userInfo;
                popup.IsOpen = true;

                var temp = sender as Image;
                var temp2 = temp.Parent as Grid;
                var temp3 = temp2.Children[temp2.Children.Count - 1] as Popup;
                temp3.IsOpen = true;

            }
            catch 
            {
 
            }        
        }

        


        public delegate void MouseDownHanler1(object sender);
        /// <summary>
        /// 文件-打开文件
        /// </summary>
        public event MouseDownHanler1 OpenFileEvent;

        public delegate void MouseDownHanler2(object sender);
        /// <summary>
        /// 文件-打开文件所在文件夹
        /// </summary>
        public event MouseDownHanler2 OpenFolderEvent;

        public delegate void MouseDownHanler3(object sender);
        /// <summary>
        /// 文件-转发
        /// </summary>
        public event MouseDownHanler3 TransferOtherEvent;

        public delegate void MouseDownHanler4(object sender);
        /// <summary>
        /// 文件-取消下载
        /// </summary>
        public event MouseDownHanler4 OffTransferEvent;
        public delegate void MouseDownHanler5(object sender);
        /// <summary>
        /// 文件-下载
        /// </summary>
        public event MouseDownHanler5 DownFileEvent;
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (OpenFileEvent != null && temp2 != null)
                OpenFileEvent(temp2);
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (OpenFolderEvent != null && temp2 != null)
                OpenFolderEvent(temp2);
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (TransferOtherEvent != null && temp2 != null)
                TransferOtherEvent(temp2);
        }

        private void Hyperlink_Click_3(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (OffTransferEvent != null && temp2 != null)
                OffTransferEvent(temp2);
        }
        private void Hyperlink_Click_4(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (DownFileEvent != null && temp2 != null)
                DownFileEvent(temp2);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            HiddenNewMassage();
        }

        public delegate void DropHanler(string filePath);
        /// <summary>
        /// 拖拽文件到控件事件
        /// </summary>
        public event DropHanler DropEvent;
        private void UserControl_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var temp = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                if(DropEvent!=null)
                  DropEvent(temp);
            }
        }

        public delegate void ScrollChangedEndHanler();
        /// <summary>
        /// 消息滚动到底
        /// </summary>
        public event ScrollChangedEndHanler ScrollChangedEndEvent;

        public delegate void ScrollChangedHomeHanler();
        /// <summary>
        /// 消息滚动到顶
        /// </summary>
        public event ScrollChangedHomeHanler ScrollChangedHomeEvent;

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (Math.Abs(e.VerticalChange) >0)
            {              
                var scrollViewer = sender as ScrollViewer;
                //滚动到底
                if (e.ViewportHeight + e.VerticalOffset == scrollViewer.ExtentHeight && (e.ViewportHeightChange == 0 && e.ExtentHeightChange == 0))
                {
                    HiddenNewMassage();
                    if (ScrollChangedEndEvent != null)
                        ScrollChangedEndEvent();

                }
                //滚动到顶
                if (e.VerticalOffset == 0 && (e.ViewportHeightChange == 0 && e.ExtentHeightChange == 0))
                {
                    if (ScrollChangedHomeEvent != null)
                        ScrollChangedHomeEvent();
                }
            }
         
        }

      
        public delegate void InUserInfoPageSendMessageHanler(object sender);
        /// <summary>
        /// 在用户信息弹窗点击发送消息按钮
        /// </summary>
        public event InUserInfoPageSendMessageHanler InUserInfoPageSendMessageEvent;
        private void leftUserInfo_SendMessage(object sender)
        {
            if (InUserInfoPageSendMessageEvent != null)
                InUserInfoPageSendMessageEvent(sender);
        }
        private void HiddenNewMassage()
        {
            newMassageBorder.Visibility = Visibility.Collapsed;
            var temp = Helper.VisualTreeHelperCstm.GetChildObjects<ScrollViewer>(listBox, "scrollViewer")?.First();
            temp.ScrollToEnd();
            messageCount = 0;
        }

        public delegate void ImageClickHanler(object sender);
        /// <summary>
        /// 消息中点击图片事件
        /// </summary>
        public event ImageClickHanler ImageClickEvent;
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var temp = sender as Image;
            var temp2 = temp?.DataContext;
            if (ImageClickEvent != null)
                ImageClickEvent(temp2);
        }
        #endregion

        #region public
        /// <summary>
        /// 新消息提醒
        /// </summary>
        /// <param name="msg"></param>
        public void HaveNewMassage(string msg = "有1条未读消息",int num=0)
        {
            newMassageBorder.Visibility = Visibility.Visible;
            if (num == 0)
            {
                messageCount++;
                if (messageCount<=1)
                {
                    massageTextBlock.Text = msg;
                }
                else
                {                   
                    massageTextBlock.Text = "有" + messageCount + "条未读消息";
                }
            }
            else
            {               
                massageTextBlock.Text = "有"+ num + "条未读消息";
            }
         
        }

        /// <summary>
        /// 跳转到指定消息位置
        /// </summary>
        /// <param name="id">消息id</param>
        public void ScrollToMassage(int id)
        {
            foreach (MessageModel temp in listBox.Items)
            {               
                if (temp.ID == id)
                {
                    var index= listBox.Items.IndexOf(temp);
                    var StackPanel = Helper.VisualTreeHelperCstm.GetChildObjects<StackPanel>(listBox, "").First();
                    var scrollViewer = Helper.VisualTreeHelperCstm.GetChildObjects<ScrollViewer>(listBox, "scrollViewer")?.First();
                    var currentScrollPosition = scrollViewer.VerticalOffset;
                    var point = new Point(0, currentScrollPosition);
                    var targetPosition = StackPanel.Children[index].TransformToVisual(scrollViewer).Transform(point);
                    scrollViewer.ScrollToVerticalOffset(targetPosition.Y);
                    break;
                }
            }
        }






        #endregion

     
    }
}
