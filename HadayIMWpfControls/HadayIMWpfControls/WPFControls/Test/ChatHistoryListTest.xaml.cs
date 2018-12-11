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
    /// ChatHistoryListTest.xaml 的交互逻辑
    /// </summary>
    public partial class ChatHistoryListTest : UserControl
    {
        ObservableCollection<MessageModel> messageModelsList;
        UserInfoModel userInfo;
        UserInfoModel otherUserInfo;

        public ChatHistoryListTest()
        {
            InitializeComponent();
            //初始化控件内容
            inti();
            //初始化数据
            IntiListBoxDate();
            //用messageModelsList对chatHistoryList.listBox.ItemsSource 直接赋值自动进行数据绑定
            chatHistoryList.listBox.ItemsSource = messageModelsList;
            //查询
            chatHistoryList.SearchScopeEvent += ChatHistoryList_SearchScopeEvent;        
            //日期控件切换选中
            chatHistoryList.SelectedDateEvent += ChatHistoryList_SelectedDateEvent;
            //翻页操作
            chatHistoryList.HomePageEvent += ChatHistoryList_HomePageEvent;
            chatHistoryList.PageDownEvent += ChatHistoryList_PageDownEvent;
            chatHistoryList.PageUpEvent += ChatHistoryList_PageUpEvent;
            chatHistoryList.EndPageEvent += ChatHistoryList_EndPageEvent;
            //点击小喇叭按钮
            chatHistoryList.HistoryClickEvent += ChatHistoryList_HistoryClickEvent;
            //文件操作
            chatHistoryList.OpenFileEvent += ChatList_OpenFileEvent;
            chatHistoryList.OpenFolderEvent += ChatList_OpenFolderEvent;
            chatHistoryList.TransferOtherEvent += ChatList_TransferOtherEvent;
            chatHistoryList.OffTransferEvent += ChatList_OffTransferEvent;
            chatHistoryList.DownFileEvent += ChatList_DownFileEvent;

            
        }



        #region 事件

        private void ChatList_DownFileEvent(object sender)
        {
            var temp = sender as MessageModel;
        }

        private void ChatList_OffTransferEvent(object sender)
        {
            var temp = sender as MessageModel;
        }

        private void ChatList_TransferOtherEvent(object sender)
        {
            var temp = sender as MessageModel;
        }

        private void ChatList_OpenFolderEvent(object sender)
        {
            var temp = sender as MessageModel;
        }

        private void ChatList_OpenFileEvent(object sender)
        {
            var temp = sender as MessageModel;
        }
        private void ChatHistoryList_HistoryClickEvent()
        {
             
        }

        private void ChatHistoryList_EndPageEvent()
        {
           
        }

        private void ChatHistoryList_PageUpEvent()
        {
           
        }

        private void ChatHistoryList_PageDownEvent()
        {
            
        }

        private void ChatHistoryList_SelectedDateEvent(DateTime? dateTime)
        {
            //日期控件切换选中
        }

        private void ChatHistoryList_HomePageEvent()
        {
            //首页   
        }

        private void ChatHistoryList_SearchScopeEvent(string data, string key)
        {
            //查询

        }

        #endregion
        
        private void inti()
        {
            //日期控件
            List<DateTime> listDateTime = new List<DateTime>();
            listDateTime.Add(new DateTime(2018, 10, 10));
            listDateTime.Add(new DateTime(2018, 10, 12));
            chatHistoryList.IntiDatePickerBlackoutDates(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(10), listDateTime);
            //下拉控件
            List<string> listString = new List<string>() { "最近一周", "最近一月", "最近一年" };
            chatHistoryList.InitComboBox(listString);            
        }

        private void IntiListBoxDate()
        {
            var imageTemp = new BitmapImage(new Uri(@"d:\1.jpg", UriKind.Absolute));
            userInfo = new UserInfoModel();
            userInfo.UserImage = @"d:\1.jpg";
            userInfo.UserID = "X000000";
            userInfo.UserName = "小明本人";
            userInfo.UserPhone = "13812345678";
            userInfo.UserTelephone = "0771-25123453";
            userInfo.UserEmail = "123456@qq.com";

            otherUserInfo = new UserInfoModel();
            otherUserInfo.UserImage = @"d:\1.jpg";
            otherUserInfo.UserID = "X000001";
            otherUserInfo.UserName = "张三";
            otherUserInfo.UserPhone = "13812345678";
            otherUserInfo.UserTelephone = "0771-25123453";
            otherUserInfo.UserEmail = "123456@qq.com";

            messageModelsList = new ObservableCollection<MessageModel>();
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Left,
                UserInfo = otherUserInfo,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
                MessageTime= DateTime.Now.ToString(),
                IsShowUserName=true
            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Text,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
                MessageTime = DateTime.Now.ToString()
            });
            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.Image,
            //    OrientationType = OrientationTypes.Left,
            //    UserInfo = otherUserInfo,
            //    Message = @"d:\2.jpg",
            //    MessageTime = DateTime.Now.ToString()
            //});
            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.Image,
            //    OrientationType = OrientationTypes.Right,
            //    UserInfo = userInfo,
            //    Message = @"d:\01.gif",
            //    MessageTime = DateTime.Now.ToString()
            //});

            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.Quote,
            //    OrientationType = OrientationTypes.Left,
            //    UserInfo = otherUserInfo,
            //    QuoteChatMessage = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
            //    Message = "收到、",
            //    MessageTime = DateTime.Now.ToString()
            //});
            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.Quote,
            //    OrientationType = OrientationTypes.Right,
            //    UserInfo = userInfo,
            //    QuoteChatMessage = "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString() + "现在时间" + DateTime.Now.ToString(),
            //    Message = "收到、",
            //    MessageTime = DateTime.Now.ToString()
            //});

            //FileModel fileTest = new FileModel()
            //{
            //    FileMsg = "已发送",
            //    FileName = "text.exe",
            //    FileSize = "99.0M",
            //    FileProgressValue = 100,
            //};
            //MessageModel messageModelTest = new MessageModel()
            //{
            //    ID = 123,
            //    MessageType = MessageTypes.File,
            //    OrientationType = OrientationTypes.Left,
            //    UserInfo = otherUserInfo,
            //    Message = @"d:\2.jpg",
            //    FileModel = fileTest,
            //    MessageTime = DateTime.Now.ToString()

            //};

            //messageModelsList.Add(messageModelTest);
            //messageModelsList.Add(new MessageModel()
            //{
            //    ID = DateTime.Now.Second,
            //    MessageType = MessageTypes.File,
            //    OrientationType = OrientationTypes.Right,
            //    UserInfo = userInfo,
            //    FileModel = new FileModel() {
            //        FileMsg = "已发送",
            //        FileName = "text.exe",
            //        FileSize = "99.0M",
            //        FileProgressValue = 100,
            //    },                
            //    MessageTime = DateTime.Now.ToString()
            //});
        }  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //插入数据
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.RichText,
                OrientationType = OrientationTypes.Left,
                UserInfo = userInfo,
                Message = "123345[&:0]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]123345[&:1]",
                MessageTime = DateTime.Now.ToString()
            });
            messageModelsList.Add(new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.RichText,
                OrientationType = OrientationTypes.Right,
                UserInfo = userInfo,
                Message = "123345[&:0]123345[&:1]",
                MessageTime = DateTime.Now.ToString()
            });
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                "查询条件是否展示：" + chatHistoryList.IsSeachBorderVisibility.ToString() +
                ",查询条件选择:" + chatHistoryList.SearchSelectedData.ToString() +
                ",查询内容：" + chatHistoryList.SearchString

                );
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //设置翻页按钮是否可选
            chatHistoryList.HomePageEnable = false ;
            chatHistoryList.PageUpEnable = false ;
            chatHistoryList.PageDownEnable = false ;
            chatHistoryList.EndPageEnable = false;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //设置小喇叭是否显示
            chatHistoryList.IsHistoryManagerButtonVisibility = !chatHistoryList.IsHistoryManagerButtonVisibility;
            chatHistoryList.IsDatePickerVisibility = !chatHistoryList.IsDatePickerVisibility;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            chatHistoryList.SelectedDate = null;
            chatHistoryList.SelectedDate = DateTime.Now.AddDays(1);
            MessageBox.Show(
               "查询时间：" + chatHistoryList.SelectedDate.ToString()

               );

        }

        MessageModel imageModel;
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
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
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Left,
                Message = @"d:\1.jpg",
            };
            messageModelsList.Add(imageModel);
            imageModel = new MessageModel()
            {
                ID = DateTime.Now.Second,
                MessageType = MessageTypes.Image,
                OrientationType = OrientationTypes.Left,
                Message = @"d:\9.jpg",
            };
            messageModelsList.Add(imageModel);

        }
    }
}
