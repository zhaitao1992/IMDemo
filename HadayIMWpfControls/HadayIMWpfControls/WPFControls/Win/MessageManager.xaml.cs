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
    /// MessageManager.xaml 的交互逻辑
    /// </summary>
    public partial class MessageManager : Window
    {
        ObservableCollection<ChatNavigationModel> chatNavigationModels;

        public MessageManager()
        {
            InitializeComponent();           
            chatNavigationList.SelectionChanged += ChatNavigationList_SelectionChanged;
            //初始化数据 使用时按照自己需求对导航及聊天历史列表进行数据初始化
            InitData();
        }
        #region 窗口操作
        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //关闭窗口
            this.Close();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //最小化
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //最大化
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //双击判断
            if (e.ClickCount == 2)
            {
                if (this.WindowState != WindowState.Maximized)
                {
                    this.WindowState = WindowState.Maximized;
                }
                else if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                }
            }

        }
        #endregion

        private void InitData()
        {
            chatNavigationModels = new ObservableCollection<ChatNavigationModel>();
            var imageTemp = new BitmapImage(new Uri(@"d:\2.jpg", UriKind.Absolute));
            for (int i = 1; i < 6; i++)
            {
                chatNavigationModels.Add(new ChatNavigationModel()
                {
                    UserID = i.ToString(),
                    HeadImage = imageTemp,
                    UserName = "张三" + i,                   
                });
            }
            chatNavigationList.ItemsSource = chatNavigationModels;
        }
        private void ChatNavigationList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //导航切换人选
            #region 设置选择人员消息
            var temp = chatNavigationList.SelectedItem as ChatNavigationModel;
            otherUser.Text ="与 "+ temp?.UserName + "(" + temp?.UserID+ ") 的消息记录";
            #endregion

        }
        private void icon_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //导航删除按钮
            var temp = chatNavigationList.SelectedItem as ChatNavigationModel;

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //刷新按钮
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //删除按钮
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //上传按钮
        }



    }
}
