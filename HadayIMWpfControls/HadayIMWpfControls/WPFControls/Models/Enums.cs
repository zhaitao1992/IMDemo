using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadayIMWpfControls.WPFControls
{
    //消息类型
    public enum MessageTypes
    {
        Text,
        Image,
        File,        
        Quote,//引用文字
        SystemMessage,//系统消息
        SystemMessageWithOutBubble,//系统消息,不带气泡
        RichText,//富文本
    }
    //在消息窗的方向
    public enum OrientationTypes
    {
        Left,
        Right
    }
    public enum ImageState
    {
        Normal,//普通状态
        Loading,//传输状态，显示loading与进度条
        Error//失败状态，显示失败图标
    }
    public enum FileState
    {

        TransferBefor,//传输前 显示下载、取消
        Transmitting,//传输中 显示取消
        TransferOver,//传输完成 显示 打开 打开文件夹 转发
        DownAgain//再次下载 显示下载
    }

}
