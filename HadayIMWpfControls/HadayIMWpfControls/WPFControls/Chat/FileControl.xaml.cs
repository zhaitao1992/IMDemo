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
    /// Document.xaml 的交互逻辑
    /// </summary>
    public partial class FileControl : UserControl
    {
        public FileControl()
        {
            InitializeComponent();            
        }
        public FileControl(string fileName,string fileSize,string msg="发送中...")
        {
            InitializeComponent();
            fileNameTextBlock.Text = fileName;
            fileSizeTextBlock.Text = fileSize;
            msgTextBlock.Text = msg;
        }

        public static readonly DependencyProperty ProgressBarValueProperty = DependencyProperty.Register("ProgressBarValue"
            , typeof(double), typeof(FileControl), new FrameworkPropertyMetadata(OnProgressBarValueChanged));

        public double ProgressBarValue
        {
            get { return (double)GetValue(ProgressBarValueProperty); }
            set { SetValue(ProgressBarValueProperty, value); }
        }

        private static void OnProgressBarValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            FileControl bubble = sender as FileControl;
            bubble.progressBar.Value = (double)e.NewValue;
        }         

        public delegate void MouseDownHanler1(object sender);
        /// <summary>
        /// 打开文件
        /// </summary>
        public event MouseDownHanler1 OpenFileEvent;

        public delegate void MouseDownHanler2(object sender);
        /// <summary>
        /// 打开文件所在文件夹
        /// </summary>
        public event MouseDownHanler2 OpenFolderEvent;

        public delegate void MouseDownHanler3(object sender);
        /// <summary>
        /// 转发文件
        /// </summary>
        public event MouseDownHanler3 TransferOtherEvent;

        public delegate void MouseDownHanler4(object sender);
        /// <summary>
        /// 关闭文件传输
        /// </summary>
        public event MouseDownHanler4 OffTransferEvent;


        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            if (OpenFileEvent != null)
                OpenFileEvent(this.Tag);
        }

        private void Hyperlink_Click_1(object sender, RoutedEventArgs e)
        {
            if (OpenFolderEvent != null)
                OpenFolderEvent(this.Tag);
        }

        private void Hyperlink_Click_2(object sender, RoutedEventArgs e)
        {
            if (TransferOtherEvent != null)
                TransferOtherEvent(this.Tag);
        }

        private void progressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (e.NewValue == 100)
            {
                TransferOver.Visibility = Visibility.Visible;
                Transfer.Visibility = Visibility.Collapsed;
                msgTextBlock.Text = "已发送";
            }
            else
            {
                TransferOver.Visibility = Visibility.Collapsed;
                Transfer.Visibility = Visibility.Visible;
                msgTextBlock.Text = "发送中...";
            }
        }

        private void Hyperlink_Click_3(object sender, RoutedEventArgs e)
        {
            if (OffTransferEvent != null)
                OffTransferEvent(this.Tag);
        }
    }
}
