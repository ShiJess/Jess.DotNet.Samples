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
    /// 本示例演示使用ExecuteScalar()方法查询学员表中学员信息的数量。
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 打开数据库连接，查询学员记录数量
        private void btnTest_Click(object sender, EventArgs e)
        {
            // 创建 Connection 对象
            string connString = "Data Source=.;Initial Catalog=MySchool;User ID=sa;pwd=sa";
            SqlConnection connection = new SqlConnection(connString);

            int num = 0;  // 选员信息的数量
            string message = "";  // 弹出的结果消息
            // 查询用的 SQL 语句
            string sql = "SELECT COUNT(*) FROM Student";

            try
            {
                connection.Open();// 打开数据库连接
                // 创建 Command 对象
                SqlCommand command = new SqlCommand(sql, connection);
                // 执行 SQL 查询
                num = (int)command.ExecuteScalar();

                message = string.Format("Student表中共有{0}条学员信息！",num);
                MessageBox.Show(message,"查询结果",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception exp)
            {
                // 操作出错
                MessageBox.Show(exp.Message);
            }
            finally
            {
                // 关闭数据库连接
                connection.Close();                
            }
        }
    }
}