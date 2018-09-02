using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MySchool
{
    /// <summary>
    /// 此类维护数据库连接字符串，和 Connection 对象
    /// </summary>
    class DBHelper
    {
        // 数据库连接字符串
        private static string connString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;Pwd=sa";

        // 数据库连接 Connection 对象
        public static SqlConnection connection = new SqlConnection(connString); 
    }
}
