using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    /// <summary>
    /// 登录窗体
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // 点击取消按钮，关闭应用程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 点击登录按钮时，设置用户名和登录类型
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginId.Text == "")  // 判断“用户名”文本框中的字符串是否为空
            {
                MessageBox.Show("请输入用户姓名");
                MessageBox.Show("请输入用户姓名", "输入提示");
                MessageBox.Show("请输入用户姓名", "输入提示", MessageBoxButtons.OKCancel);
                MessageBox.Show("请输入用户姓名", "输入提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }       
    }
}
