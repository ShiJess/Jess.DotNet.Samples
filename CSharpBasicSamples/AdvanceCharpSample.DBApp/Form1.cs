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
    /// 本示例演示打开和关闭数据库，并使用异常处理。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 测试打开数据库的操作，理解finally
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;pwd=sa";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                // 打开成功
                connection.Open();
                MessageBox.Show("打开数据库连接成功");                
            }
            catch (Exception ex)
            {
                // 打开失败
                MessageBox.Show("出现异常");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // 关闭数据库
                connection.Close();
                MessageBox.Show("关闭数据库连接成功");
            }
        }
    }
}