using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace HadayIMWpfControls.WPFControls.Models
{
    public class UserInfoModel :ModelBase
    {
         //用户信息弹窗
        private string _userImage;
        public string UserImage
        {
            get { return _userImage; }
            set { Set(ref _userImage,value, "UserImage"); }
        }
        private string _userID;
        public string UserID
        {
            get { return _userID; }
            set { Set(ref _userID, value, "UserID"); }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { Set(ref _userName, value, "UserName"); }
        }
        private string _userEmail;
        public string UserEmail
        {
            get { return _userEmail; }
            set { Set(ref _userEmail, value, "UserEmail"); }
        }
        private string _userPhone;
        public string UserPhone
        {
            get { return _userPhone; }
            set { Set(ref _userPhone, value, "UserPhone"); }
        }
        private string _userTelephone;
        public string UserTelephone
        {
            get { return _userTelephone; }
            set { Set(ref _userTelephone, value, "UserTelephone"); }
        }
    }
}
