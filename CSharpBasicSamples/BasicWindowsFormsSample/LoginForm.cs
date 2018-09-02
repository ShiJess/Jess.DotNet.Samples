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
            if (txtLoginId.Text == "")
            {
                DialogResult result;
                result = MessageBox.Show("请输入用户姓名", "输入提示",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("你选择了确认按钮");
                }
                else
                {
                    MessageBox.Show("你选择了取消按钮");
                }
            }
        }       
    }
}
