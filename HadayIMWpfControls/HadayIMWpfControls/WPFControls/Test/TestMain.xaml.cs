using HadayIMWpfControls.WPFControls.Models;
using HadayIMWpfControls.WPFControls.Win;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HadayIMWpfControls.WPFControls
{
    /// <summary>
    /// TestMain.xaml 的交互逻辑
    /// </summary>
    public partial class TestMain : UserControl
    {
        //聊天窗
        ChatWindow chatWindow;       
        UserInfoModel userInfo;
        UserInfoModel userInfo1;
        UserInfoModel userInfo2;
        //是否窗口分离
        bool isSeparation = false;

        //头像导航列表
        ObservableCollection<ChatNavigationModel> chatNavigationModelsList = new ObservableCollection<ChatNavigationModel>();
        //用户、消息列表
        List<Tuple<UserInfoModel, ObservableCollection<MessageModel>>> messageList = new List<Tuple<UserInfoModel, ObservableCollection<MessageModel>>>();
        //隐藏窗体列表
        List<ChatWindow> chatWindowsList = new List<ChatWindow>();

        public TestMain()
        {
            InitializeComponent();
            var imageTemp = new BitmapImage(new Uri(@"d:\1.jpg", UriKind.Absolute));
            userInfo = new UserInfoModel();
            userInfo.UserImage = @"d:\1.jpg";
            userInfo.UserID = "X000000";
            userInfo.UserName = "小明本人";
            userInfo.UserPhone = "13812345678";
            userInfo.UserTelephone = "0771-25123453";
            userInfo.UserEmail = "123456@qq.com";

            
            userInfo1 = new UserInfoModel();
            userInfo1.UserImage = @"d:\1.jpg";
            userInfo1.UserID = "X000001";
            userInfo1.UserName = "张三";
            userInfo1.UserPhone = "13812345678";
            userInfo1.UserTelephone = "0771-25123453";
            userInfo1.UserEmail = "123456@qq.com";


            userInfo2 = new UserInfoModel();
            userInfo2.UserImage = @"d:\1.jpg";
            userInfo2.UserID = "X000002";
            userInfo2.UserName = "李四";
            userInfo2.UserPhone = "138123456789";
            userInfo2.UserTelephone = "0771-25123453";
            userInfo2.UserEmail = "1234567@qq.com";


            //初始化设置当前用户
            chatWindow = new ChatWindow(userInfo);

            //设置数据
            chatWindow.chatNavigationList.listBox.ItemsSource = chatNavigationModelsList;
           

            // 用户头像导航列表数据源更改时更改窗体样式
            chatNavigationModelsList.CollectionChanged += ChatNavigationModelsList_CollectionChanged;

            
            //关闭与某个用户聊天导航头像
            chatWindow.chatNavigationList.CloseUserEvent += ChatNavigationList_CloseUserEvent;      
            //聊天窗体关闭
            chatWindow.Closing += ChatWindow_Closing;
            //合并分离
            chatWindow.WindowSeparationEvent += ChatWindow_WindowSeparationEvent;
            //用户发送消息
            chatWindow.SendMessageEvent += ChatWindow_SendMessageEvent;
            //用户导航切换
            chatWindow.SelectionChangedEvent1 += ChatWindow_SelectionChangedEvent1;


        }

        private void ChatWindow_SelectionChangedEvent1(ChatNavigationModel sender)
        {
            if (messageList.Count == 0) return;
            var temp = messageList.Where(o => o.Item1.UserID == sender.UserID).Count();
            if (temp > 0)
            {
                chatWindow.chatList.listBox.ItemsSource = messageList.Where(o => o.Item1.UserID == sender.UserID).First().Item2;
                chatWindow.DataContext= messageList.Where(o => o.Item1.UserID == sender.UserID).First().Item1;
            }
                
        }

        private void ChatWindow_SendMessageEvent(UserInfoModel userInfoModel, MessageModel messageModel)
        {

            messageList.Where(o => o.Item1 == userInfoModel)?.First().Item2.Add(messageModel);

        }

        
        private void ChatWindow_WindowSeparationEvent(bool isSeparation)
        {
            
            if (isSeparation)
            {
                //拆分
                if(this.isSeparation)return;
                //根据chatNavigationModelsList数量拆分窗口
                for (int i =0;i< chatNavigationModelsList.Count();i++)
                {
                    chatWindowsList.Add(new ChatWindow(userInfo) { DataContext= messageList.Where(o=>o.Item1.UserID== chatNavigationModelsList[i].UserID).First().Item1  });
                }
                foreach (var temp in chatWindowsList)
                {                    
                    var temp2= temp.DataContext as UserInfoModel;
                    temp.chatList.listBox.ItemsSource = messageList.Where(o => o.Item1.UserID == temp2.UserID)?.First().Item2;
                    temp.SendMessageEvent += ChatWindow_SendMessageEvent;
                    temp.WindowSeparationEvent += ChatWindow_WindowSeparationEvent;
                    temp.Show();
                }
                chatWindow.Hide();
            }
            else
            {
                //合并
                chatWindow.Show();
                foreach (var temp in chatWindowsList)
                {
                    temp.CloseThisWindow();
                }
                chatWindowsList.Clear();
            }
            this.isSeparation = isSeparation;
        }

        

        private void ChatNavigationModelsList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (!isSeparation)
            {
                if (chatNavigationModelsList.Count > 1)
                {
                    chatWindow.chatNavigationList.Visibility = Visibility.Visible;
                    chatWindow.Width = 1000;
                }
                else
                {
                    chatWindow.chatNavigationList.Visibility = Visibility.Collapsed;
                    chatWindow.Width = 800;
                }
            }   
        }      

        private void ChatWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            chatNavigationModelsList.Clear();
             
        }

        private void ChatNavigationList_CloseUserEvent(ChatNavigationModel sender)
        {
            chatNavigationModelsList.Remove(sender);
        }
         

        private void TextBlock_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            var textBlock = sender as TextBlock; 
            if (!isSeparation)
            {
                chatWindow.Show();
                if (textBlock.Text == "张三")
                {
                    // 这里用切换chatWindow(消息窗体)的DataContext 去设置导航的选择中项
                    chatWindow.DataContext = userInfo1;

                    if (chatNavigationModelsList.Where(o => o.UserID == userInfo1.UserID).ToList().Count == 0)
                    {
                        chatNavigationModelsList.Add(new ChatNavigationModel()
                        {
                            UserID = userInfo1.UserID,
                            //HeadImage = userInfo1.UserImage,
                            UserName = userInfo1.UserName,
                            Message = "12345678910121314151617",
                            MessageTime = "10:11"
                        });
                        if (messageList.Where(o => o.Item1.UserID == userInfo1.UserID).Count() == 0)
                            messageList.Add(new Tuple<UserInfoModel, ObservableCollection<MessageModel>>(userInfo1, new ObservableCollection<MessageModel>()));

                    }
                    chatWindow.chatList.listBox.ItemsSource = messageList.Where(o => o.Item1 == userInfo1)?.First().Item2;
                }
                if (textBlock.Text == "李四")
                {

                    // 这里用切换chatWindow的DataContext 去设置导航的选择中项
                    chatWindow.DataContext = userInfo2;
                    if (chatNavigationModelsList.Where(o => o.UserID == userInfo2.UserID).ToList().Count == 0)
                    {
                        chatNavigationModelsList.Add(new ChatNavigationModel()
                        {
                            UserID = userInfo2.UserID,
                            //HeadImage = userInfo2.UserImage,
                            UserName = userInfo2.UserName,
                            Message = "123456789..................",
                            MessageTime = "10:11"
                        });
                        if (messageList.Where(o => o.Item1.UserID == userInfo2.UserID).Count() == 0)
                            messageList.Add(new Tuple<UserInfoModel, ObservableCollection<MessageModel>>(userInfo2, new ObservableCollection<MessageModel>()));

                    }
                    chatWindow.chatList.listBox.ItemsSource = messageList.Where(o => o.Item1 == userInfo2)?.First().Item2;
                }
            }
            else
            {
                if (textBlock.Text == "张三")
                {
                    for (int i=0;i< chatWindowsList.Count();i++)
                    {
                        var temp= chatWindowsList[i].DataContext as UserInfoModel;
                        if (temp.UserName == "张三")
                        {
                            chatWindowsList[i].Activate();
                            break;
                        }                        
                    }
                }
                if(textBlock.Text == "李四")
                {
                    for (int i = 0; i < chatWindowsList.Count(); i++)
                    {
                        var temp = chatWindowsList[i].DataContext as UserInfoModel;
                        if (temp.UserName == "李四")
                        {
                            chatWindowsList[i].Activate();
                            break;
                        }
                    }
                }

            }

        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageManager messageManager = new MessageManager();
            messageManager.Show();
        }
    }
}
