using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HadayIMWpfControls.WPFControls.Models
{
    public class ChatNavigationModel:ModelBase
    {
        //导航
        
        private string _userID;
        public string UserID
        {
            get { return _userID; }
            set { Set(ref _userID, value); }
        }
        private BitmapImage _headImage;
        public BitmapImage HeadImage
        {
            get { return _headImage; }
            set { Set(ref _headImage, value); }
        }
        public string _userName;
        public string UserName
        {
            get { return _userName; }
            set { Set(ref _userName, value); }
        }
        public string _message;
        public string Message
        {
            get { return _message; }
            set { Set(ref _message, value); }
        }
        public string _messageTime;
        public string MessageTime
        {
            get { return _messageTime; }
            set { Set(ref _messageTime, value); }
        }

    }
}
