using HadayIMWpfControls.WPFControls.Models;
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
    /// ChatNavigationList.xaml 的交互逻辑
    /// </summary>
    public partial class ChatNavigationList : UserControl
    {
        public ChatNavigationList()
        {
            InitializeComponent();           
            if (listBox.Items?.Count > 0)
            {
                listBox.SelectedIndex=0;
            }
        }

        public delegate void SelectionChangedHanler(ChatNavigationModel sender);
        /// <summary>
        /// 切换用户
        /// </summary>
        public event SelectionChangedHanler SelectionChangedEvent;
        public delegate void CloseUserHanler(ChatNavigationModel sender);
        /// <summary>
        /// 关闭用户
        /// </summary>
        public event CloseUserHanler CloseUserEvent;
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var temp = listBox.SelectedItem as ChatNavigationModel;
            if (temp == null)
            {
                return;
            }
            else
            {
                if(SelectionChangedEvent!=null)
                     SelectionChangedEvent(temp);               
            }          
        }

        private void icon_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var temp = listBox.SelectedItem as ChatNavigationModel;
            if (CloseUserEvent != null)
                CloseUserEvent(temp);
        }

    }
}
