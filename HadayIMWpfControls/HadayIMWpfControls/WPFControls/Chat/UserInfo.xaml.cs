using System;
using System.Collections.Generic;
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
    /// UserInfo.xaml 的交互逻辑
    /// </summary>
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
        }
        //public UserInfo(BitmapImage image, string number, string name, string email, string phone, string telephone)
        //{
        //    InitializeComponent();
        //    headImage.Source = image;
        //    numberTextBlock.Text = number;
        //    nameTextBlock.Text = name;
        //    emailTextBlock.Text = email;
        //    phoneTextBlock.Text = phone;
        //    telephoneTextBlock.Text = telephone;           
        //}

        public delegate void MouseDownHanler1(object sender);
        /// <summary>
        ///发送消息
        /// </summary>
        public event MouseDownHanler1 SendMessage;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SendMessage != null)
                SendMessage(this.DataContext);
        }
    }
}
