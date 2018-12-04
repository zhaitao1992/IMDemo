using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadayIMWpfControls.WPFControls.Models
{
    //消息
    public class MessageModel : ModelBase
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { Set(ref _id, value, "ID"); }
        }
        private MessageTypes _messageType;
        public MessageTypes MessageType
        {
            get { return _messageType; }
            set { Set(ref _messageType, value, "MessageTypes"); }
        }

        private OrientationTypes _orientationType;
        public OrientationTypes OrientationType
        {
            get { return _orientationType; }
            set { Set(ref _orientationType, value, "OrientationType"); }
        }

        public UserInfoModel _userInfo;
        public UserInfoModel UserInfo
        {
            get { return _userInfo; }
            set { Set(ref _userInfo, value, "UserInfo"); }
        }
        private string _message;
        public string Message
        {
            get { return _message; }
            set { Set(ref _message, value, "Message"); }
        }
        private string _messageTime;

        public string MessageTime
        {
            get { return _messageTime; }
            set { Set(ref _messageTime, value, "MessageTime"); }
        }
        private FileModel _fileModel;
        public FileModel FileModel
        {
            get { return _fileModel; }
            set { Set(ref _fileModel, value, "FileModel"); }
        }
        private string _quoteChat;
        public string QuoteChatMessage
        {
            get { return _quoteChat; }
            set { Set(ref _quoteChat, value, "QuoteChatMessage"); }
        }
        //默认色
        private string _bubbleBackground = "#E6E6E6";

        public string BubbleBackground
        {
            get { return _bubbleBackground; }
            set { Set(ref _bubbleBackground, value, "BubbleBackground"); }
        }

        private double _imageProgressValue;
        public double ImageProgressValue
        {
            get { return _imageProgressValue; }
            set { Set(ref _imageProgressValue, value, "ImageProgressValue"); }
        }

        private ImageState _imageState=ImageState.Normal;
        public ImageState ImageState
        {
            get { return _imageState; }
            set { Set(ref _imageState, value, "ImageState"); }
        }

        private bool _isShowUserName;
        public bool IsShowUserName
        {
            get { return _isShowUserName; }
            set { Set(ref _isShowUserName, value, "IsShowUserName"); }
        }


    }
}
