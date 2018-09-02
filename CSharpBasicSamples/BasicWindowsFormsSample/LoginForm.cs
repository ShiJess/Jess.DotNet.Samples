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
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtLogInId.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogInId.Focus();               
            }
        }       
    }
}
