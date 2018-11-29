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
    /// ChatHistoryList.xaml 的交互逻辑
    /// </summary>
    public partial class ChatHistoryList : UserControl
    {
        private bool _homePageEnable=true;
        /// <summary>
        /// 首页按钮Enable
        /// </summary>
        public bool HomePageEnable
        {
            get { return _homePageEnable; }
            set
            {
                _homePageEnable =value;
                navigate_left.IsEnabled = _homePageEnable;
            }
        }
        private bool _pageUpEnable = true;
        /// <summary>
        /// 上一页按钮Enable
        /// </summary>
        public bool PageUpEnable
        {
            get { return _pageUpEnable; }
            set
            {
                _pageUpEnable = value;
                arrow_left.IsEnabled = _pageUpEnable;
            }
        }
        private bool _pageDownEnable = true;
        /// <summary>
        /// 下一页按钮Enable
        /// </summary>
        public bool PageDownEnable
        {
            get { return _pageDownEnable; }
            set
            {
                _pageDownEnable = value;
                arrow_right.IsEnabled = _pageDownEnable;
            }
        }
        private bool _endPageEnable = true;
        /// <summary>
        /// 尾页按钮Enable
        /// </summary>
        public bool EndPageEnable
        {
            get { return _endPageEnable; }
            set
            {
                _endPageEnable = value;
                navigate_right.IsEnabled = _endPageEnable;
            }
        }
        private bool _isDatePickerVisibility = true;
        /// <summary>
        /// 日期选择控件是否显示
        /// </summary>
        public bool IsDatePickerVisibility
        {
            get { return _isDatePickerVisibility; }
            set
            {
                _isDatePickerVisibility = value;
                if (_isDatePickerVisibility)
                {
                    DatePicker.Visibility = Visibility.Visible;
                }
                else
                {
                    DatePicker.Visibility = Visibility.Collapsed;
                }
            }
        }
        private bool _isHistoryManagerButtonVisibility = true;
        /// <summary>
        /// 消息管理器按钮是否显示
        /// </summary>
        public bool IsHistoryManagerButtonVisibility
        {
            get { return _isHistoryManagerButtonVisibility; }
            set
            {
                _isHistoryManagerButtonVisibility = value;
                if (_isHistoryManagerButtonVisibility)
                {
                    historyButton.Visibility = Visibility.Visible;
                }
                else
                {
                    historyButton.Visibility = Visibility.Collapsed;
                }
            }
        }
        private bool _isSeachBorderVisibility = false;
        /// <summary>
        /// 消息搜索条件框是否显示
        /// </summary>
        public bool IsSeachBorderVisibility
        {
            get { return _isSeachBorderVisibility; }
            set
            {
                _isSeachBorderVisibility = value;
                if (_isSeachBorderVisibility)
                {
                    seachBorder.Visibility = Visibility.Visible;
                }
                else
                {
                    seachBorder.Visibility = Visibility.Collapsed;
                }
            }
        }
        /// <summary>
        /// 日期控件选中时间
        /// </summary>
        public DateTime? SelectedDate
        {           
            get { return DatePicker.SelectedDate; }
            set
            {
                DatePicker.SelectedDate = value;
            }            
        }

        /// <summary>
        /// 查询内容数据
        /// </summary>
        public string SearchString
        {
            get { return searchTextBox2.Text; }
            set
            {
                searchTextBox2.Text = value;
            }
        }       

        /// <summary>
        /// 查询范围条件选择数据
        /// </summary>
        public string SearchSelectedData
        {
            get { return comboBox.SelectionBoxItem?.ToString(); }            
        }


        public ChatHistoryList()
        {
            InitializeComponent();
        }
        #region private event
        public delegate void LocateHanler(MessageModel historyModel);
        /// <summary>
        /// 右键-定位消息
        /// </summary>
        public event LocateHanler LocateEvent;
        private void locate_Click(object sender, RoutedEventArgs e)
        {
            var temp = (MessageModel)listBox.SelectedItem; 
            if(LocateEvent!=null&&temp!=null)
              LocateEvent(temp);
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (seachBorder.Visibility == Visibility.Visible)
            {
                seachBorder.Visibility = Visibility.Collapsed;
                searcButton.Opacity = 0.5;
            }
            else
            {
                seachBorder.Visibility = Visibility.Visible;
                searcButton.Opacity = 1;
            }

            e.Handled = true;
        }        
        public delegate void SearchScopeHanler (string data,string key);
        /// <summary>
        /// 点击搜索确定按钮
        /// </summary>
        public event SearchScopeHanler SearchScopeEvent;
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //查询
            if (SearchScopeEvent != null)
                SearchScopeEvent(comboBox.SelectionBoxItem?.ToString(), searchTextBox2.Text);
        }
        public delegate void HomePageHanler();
        /// <summary>
        /// 翻页-首页
        /// </summary>
        public event HomePageHanler HomePageEvent;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //首页
            if (HomePageEvent != null)
                HomePageEvent();
        }
        public delegate void PageUpHanler();
        /// <summary>
        /// 翻页-上一页
        /// </summary>
        public event PageUpHanler PageUpEvent;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //上一页
            if (PageUpEvent != null)
                PageUpEvent();
        }
        public delegate void PageDownHanler();
        /// <summary>
        /// 翻页-下一页
        /// </summary>
        public event PageDownHanler PageDownEvent;
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //下一页
            if (PageDownEvent != null)
                PageDownEvent();
        }
        public delegate void EndPageHanler();
        /// <summary>
        /// 翻页-尾页
        /// </summary>
        public event EndPageHanler EndPageEvent;
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //尾页
            if (EndPageEvent != null)
                EndPageEvent();
        }
        public delegate void SelectedDateHanler(DateTime? dateTime);
        /// <summary>
        /// 日期切换选中事件
        /// </summary>
        public event SelectedDateHanler SelectedDateEvent;
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelectedDateEvent != null)
                SelectedDateEvent(DatePicker.SelectedDate);
        }
        public delegate void MouseDownHanler1(object sender);
        /// <summary>
        /// 文件-打开文件事件
        /// </summary>
        public event MouseDownHanler1 OpenFileEvent;
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (OpenFileEvent != null && temp2 != null)
                OpenFileEvent(temp2);
        }
        public delegate void MouseDownHanler2(object sender);
        /// <summary>
        /// 文件-打开文件所在文件夹事件
        /// </summary>
        public event MouseDownHanler2 OpenFolderEvent;
        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (OpenFolderEvent != null && temp2 != null)
                OpenFolderEvent(temp2);
        }
        public delegate void MouseDownHanler3(object sender);
        /// <summary>
        /// 转发文件事件
        /// </summary>
        public event MouseDownHanler3 TransferOtherEvent;
        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            var temp = sender as Hyperlink;
            var temp2 = temp?.DataContext;
            if (TransferOtherEvent != null && temp2 != null)
                TransferOtherEvent(temp2);
        }
        public delegate void MouseDownHanler4();
        /// <summary>
        /// 点击小喇叭展示消息管理器事件
        /// </summary>
        public event MouseDownHanler4 HistoryClickEvent;
        private void historyButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (HistoryClickEvent != null)
                HistoryClickEvent();
        }
        public delegate void MouseDownHanler5(object sender);
        /// <summary>
        /// 文件-取消下载事件
        /// </summary>
        public event MouseDownHanler5 OffTransferEvent;
        public delegate void MouseDownHanler6(object sender);
        /// <summary>
        /// 文件-下载文件事件
        /// </summary>
        public event MouseDownHanler6 DownFileEvent;
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
        public delegate void MouseDownHanler7(bool isShowSeachBorder, string comboBoxSelecte);
        /// <summary>
        /// 点击放大镜切换显示搜索框事件
        /// </summary>
        public event MouseDownHanler7 SeachVisibilityEvent;
        private void Imae_MouseUp(object sender, MouseButtonEventArgs e)
        {
            IsSeachBorderVisibility = !IsSeachBorderVisibility;
            if (SeachVisibilityEvent != null)
            {                
                SeachVisibilityEvent(IsSeachBorderVisibility, comboBox.SelectionBoxItem?.ToString());
            }               
        }

        #endregion
        #region public
        /// <summary>
        /// 初始化日期选择控件
        /// </summary>
        /// <param name="starDateTime">展示日期范围-开始</param>
        /// <param name="endDateTime">展示日期范围-结束</param>
        /// <param name="outList">不可选日期列表</param>
        public void IntiDatePickerBlackoutDates(DateTime starDateTime, DateTime endDateTime, List<DateTime> outList)
        {
            DatePicker.SelectedDate = null;
            DatePicker.DisplayDateStart = starDateTime;
            DatePicker.DisplayDateEnd = endDateTime;
            foreach (var temp in outList)
            {
                if (temp != DatePicker.SelectedDate)
                {
                    DatePicker.BlackoutDates.Add(new CalendarDateRange(temp));
                }
            }
        }
        /// <summary>
        /// 搜索条件下拉框初始化
        /// </summary>
        /// <param name="list"></param>
        public void InitComboBox(List<string> list)
        {
            if (list != null)
            {
                comboBox.ItemsSource = list;
                comboBox.SelectedIndex = 0;
            }
        }     
        /// <summary>
        /// 设置翻页按钮Enable
        /// </summary>
        /// <param name="navigate1">首页</param>
        /// <param name="navigate2">上一页</param>
        /// <param name="navigate3">下一页</param>
        /// <param name="navigate4">尾页</param>
        public void SetNavigateButton(bool navigate1=true, bool navigate2 = true, bool navigate3 = true, bool navigate4 = true)
        {
            HomePageEnable = navigate1;
            PageUpEnable = navigate2;
            PageDownEnable = navigate3;
            EndPageEnable = navigate4;
        }    

        #endregion

       
    }
}
