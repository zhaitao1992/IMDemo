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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HadayIMWpfControls.WPFControls
{
    /// <summary>
    /// ChatListTest.xaml 的交互逻辑
    /// </summary>
    public partial class ChatListTest : UserControl
    {
        ObservableCollection<MessageModel> messageModelsList;
        UserInfoModel userInfo;
        UserInfoModel otherUserInfo;
        MessageModel messageModelTest;
        FileModel fileTest;
        MessageModel imageModel;

        public ChatListTest()
        {
            InitializeComponent();
            IntiData();
            //直接赋值 messageModelsList到  chatList.listBox.ItemsSource 自动进行数据绑定
            chatList.listBox.ItemsSource = messageModelsList;

            //右键菜单
            chatList.CopyEvent += ChatList_CopyEvent;
            chatList.ReferenceEvent += ChatList_ReferenceEvent;
            chatList.UndoEvent += ChatList_UndoEvent;
            chatList.TranspondMeaageEvent += ChatList_TranspondMeaageEvent;

            //文件操作
            chatList.OpenFileEvent += ChatList_OpenFileEvent;
            chatList.OpenFolderEvent += ChatList_OpenFolderEvent;
            chatList.TransferOtherEvent += ChatList_TransferOtherEvent;
            chatList.OffTransferEvent += ChatList_OffTransferEvent;
            chatList.DownFileEvent += ChatList_DownFileEvent;

            //拖拽文件到控件
            chatList.DropEvent += ChatList_DropEvent;

            //消息滚动事件
            chatList.ScrollChangedEndEvent += ChatList_ScrollChangedEndEvent;
            chatList.ScrollChangedHomeEvent += ChatList_ScrollChangedHomeEvent;

            //在用户信息弹窗点击发送消息
            chatList.InUserInfoPageSendMessageEvent += ChatList_InUserInfoPageSendMessageEvent;
            
            //图像点击事件
            chatList.ImageClickEvent += ChatList_ImageClickEvent;
        }



        #region 事件
        private void ChatList_ImageClickEvent(object sender)
        {
            var temp = sender as MessageModel;
        }
        private void ChatList_InUserInfoPageSendMessageEvent(object sender)
        {
           var userinfo =  sender as UserInfoModel;
        }
        private void ChatList_ScrollChangedHomeEvent()
        {

        }

        private void ChatList_ScrollChangedEndEvent()
        {

        }

        private void ChatList_DropEvent(string filePath)
        {
            
        }
        private void ChatList_DownFileEvent(object sender)
        {
            //文件下载
        }

       
        private void ChatList_OffTransferEvent(object sender)
        {
             
        }

        private void ChatList_TransferOtherEvent(object sender)
        {
            
        }

        private void ChatList_OpenFolderEvent(object sender)
        {
           
        }

        private void ChatList_OpenFileEvent(object sender)
        {
            var message = sender as MessageModel;
        }

        private void ChatList_TranspondMeaageEvent(object o)
        {
           
        }
        
        private void ChatList_UndoEvent(object o)
        {
            
        }

        private void ChatList_ReferenceEvent(object o)
        {
          
        }

        private void ChatList_CopyEvent(object o)
        {
            var temp = o as MessageModel;
        }
        #endregion

        private void IntiData()
        {

            var imageTemp = new BitmapImage(new Uri(@"d:\2.jpg", UriKind.Absolute));
            var imageTemp2 = new BitmapImage(new Uri(@"d:\1.jpg", UriKind.Absolute));



            userInfo = new UserInfoModel();
            userInfo.UserImage = imageTemp;
            userInfo.UserID = "X000000";
            userInfo.UserName = "小明本人";
            userInfo.UserPhone = "13812345678";
            userInfo.UserTelephone = "0771-25123453";
            userInfo.UserEmail = "123456@qq.com";

            otherUserInfo = new UserInfoModel();
            otherUserInfo.UserImage = imageTemp2;
            otherUserInfo.UserID = "X000001";
            otherUserInfo.UserName = "张三";
            otherUserInfo.UserPhone = "13812345678";
            otherUserInfo.UserTelephone = "0771-25123453";
            otherUserInfo.UserEmail = "123456@qq.com";

            messageModelsList = new ObservableCollection<MessageModel>();

          
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Right,
                Message = @"d:\2.jpg",
            };
            messageModelsList.Add(imageModel);
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),

            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                Message = @"d:\2.jpg",


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = @"d:\2.jpg",


            });

            fileTest = new FileModel()
            {
                FileMsg = "测试发送中1123",
                FileName = "jpj.exe",
                FileSize = "99.0M",
                FileProgressValue = 1,
                FilegeState = FileState.TransferBefor,

            };
            messageModelTest = new MessageModel()
            {
                ID = 123,
                MessageType = MessageTypes.File,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                Message = @"d:\2.jpg",
                FileModel = fileTest,


            };
            messageModelsList.Add(messageModelTest);

            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.File,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = @"d:\2.jpg",
                FileModel = new FileModel()
                {
                    FileMsg = "测试发送中",
                    FileName = "jpj.exe",
                    FileSize = "99.0M",
                    FileProgressValue = 100,
                },


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Quote,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                QuoteChatMessage = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
                Message = "收到、",


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Quote,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                QuoteChatMessage = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
                Message = "收到、",


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.SystemMessage,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),


            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.SystemMessageWithOutBubble,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),


            });
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Right,
                Message = @"d:\2.jpg",
            };
            messageModelsList.Add(imageModel);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //直接修改数据 会改变界面值
            //fileTest.FileProgressValue = 100;
            //fileTest.FileMsg = "发送成功";
            imageModel.ImageState = ImageState.Error;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //直接修改数据 会改变界面值
            //fileTest.FileProgressValue = 0;
            //fileTest.FileMsg = "发送中...";
            imageModel.ImageState = ImageState.Loading;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {            
            //手动新消息提示  控件会在有新消息来到时自行判断
            chatList.HaveNewMassage();
            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.SystemMessageWithOutBubble,
            //    Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
            //});
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
            chatList.ScrollToMassage(123);
            //for (int i =0;i<100;i++ )
            //{
            //    messageModelsList.Add(new MessageModel()
            //    {
            //        ID = DateTime.Now.Second,
            //        MessageType = MessageTypes.RichText,
            //        OrientationType = OrientationTypes.Left,
            //        UserInfo = userInfo,
            //        Message = "[&:1]测试",
            //        MessageTime = DateTime.Now.ToString()
            //    });
            //}

           
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            messageModelsList.Insert(0,new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.RichText,
                OrientationType = OrientationTypes.Left,
                UserInfo = userInfo,
                Message = textBox.Text.ToString(),
                MessageTime = DateTime.Now.ToString()
            });
        }

        private void textBox_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = "[&:1]测试";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Left,
                UserInfo = userInfo,
                Message = "左",
                MessageTime = DateTime.Now.ToString()
            });
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = "右",
                MessageTime = DateTime.Now.ToString()
            });
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Right,
                Message = @"d:\1.jpg",
            };
            messageModelsList.Add(imageModel);
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Right,
                Message = @"d:\9.jpg",
            };
            messageModelsList.Add(imageModel);
        }

        
    }
}
