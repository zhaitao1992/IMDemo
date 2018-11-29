using HadayIMWpfControls.WPFControls.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HadayIMWpfControls.WPFControls.Win
{
    /// <summary>
    /// ChatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ChatWindow : Window
    {
        UserInfoModel myUserInfo;
        UserInfoModel othersUserInfo;      
        public ChatWindow(UserInfoModel userInfo)
        {
            InitializeComponent();
            myUserInfo = userInfo;
            chatNavigationList.SelectionChangedEvent += ChatNavigationList_SelectionChangedEvent;
        }
        public delegate void SelectionChangedHanler1(ChatNavigationModel sender);
        /// <summary>
        /// 选择用户头像切换
        /// </summary>
        public event SelectionChangedHanler1 SelectionChangedEvent1;
        private void ChatNavigationList_SelectionChangedEvent(ChatNavigationModel sender)
        {
            if (SelectionChangedEvent1 != null)
            {
                SelectionChangedEvent1(sender);
            }
        }

        /// <summary>
        /// 重写OnClosing事件 解决窗口关闭不能再开 关闭主程序需彻底结束
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
        public void CloseThisWindow()
        {
            base.Close();
        }
        public delegate void SendMessageHanler(UserInfoModel userInfoModel,MessageModel messageModel);
        /// <summary>
        /// 发送消息
        /// </summary>
        public event SendMessageHanler SendMessageEvent;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            othersUserInfo = this.DataContext as UserInfoModel;
            MessageModel messageModel = new MessageModel() {
                ID = (int)DateTime.Now.Ticks,
                MessageType = MessageTypes.Text,
                OrientationType= OrientationTypes.Right,
                UserInfo = othersUserInfo,
                Message = "现在时间是" + DateTime.Now.ToString()
            };
            if (SendMessageEvent!=null)
               SendMessageEvent(othersUserInfo,messageModel);
        }         

        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //这里用切换DataContext 去设置导航的选择中项
            var temp = this.DataContext as UserInfoModel;
            if (temp == null) return;           
            var templist = chatNavigationList.listBox.ItemsSource as ObservableCollection<ChatNavigationModel>;
            if (templist == null) return;
            othersUserInfo = temp;
            if (templist.Where(o => o.UserID == temp.UserID).ToList().Count > 0)
            {
                chatNavigationList.listBox.SelectedIndex = chatNavigationList.listBox.Items.IndexOf(templist.Where(o => o.UserID == temp.UserID).First());
            }
            else
            {
                chatNavigationList.listBox.SelectedIndex = chatNavigationList.listBox.Items.Count;
            }
           
        }

        public delegate void WindowSeparationHanler(bool isSeparation);
        /// <summary>
        /// 窗口分离合并操作
        /// </summary>
        public event WindowSeparationHanler WindowSeparationEvent;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (WindowSeparationEvent != null)
                WindowSeparationEvent(true);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (WindowSeparationEvent != null)
                WindowSeparationEvent(false);               
        }
        
    }
}
