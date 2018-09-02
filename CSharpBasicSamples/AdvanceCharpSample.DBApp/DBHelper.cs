using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ConnectionAccess
{
    class DBHelper
    {
        //Access数据库的连接字符串
        public static string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Environment.CurrentDirectory+"\\MySchool.mdb"; 
         
        //创建connection对象
        public static OleDbConnection connection = new OleDbConnection(conn);
    }
}
