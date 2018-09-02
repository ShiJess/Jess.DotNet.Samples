using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OpenCloseDB
{
    /// <summary>
    /// 本示例演示打开和关闭数据库。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 测试打开数据库的操作
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;pwd=sa";
            SqlConnection connection = new SqlConnection(connString);
            
            // 打开数据库连接
            connection.Open();
            MessageBox.Show("打开数据库连接成功");                
            
            // 关闭数据库连接
            connection.Close();
            MessageBox.Show("关闭数据库连接成功");
            
        }
    }
}