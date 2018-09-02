using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace MySchool
{
    /// <summary>
    /// 该类用以存放登录的用户名和类型，便于窗体间的数据传递
    /// </summary>
    public class UserHelper
    {
        public static string loginId = "";  // 用户名
        public static string loginType = "";  // 登录类型
    }
}
