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
            // 调用用户验证方法，根据返回值确定是否通过验证
            if (ValidateInput())
            {
                MessageBox.Show("验证成功");
            }
            else
            {
                MessageBox.Show("验证失败");
            }
        }

        /// <summary>
        /// 验证用户是否进行了输入和选择
        /// </summary>
        private bool ValidateInput()
        {
            if (txtLogInId.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogInId.Focus();
                return false;
            }
            else if (txtLogInPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogInPwd.Focus();
                return false;
            }
            else if (cboLogInType.Text.Trim() == "")
            {
                MessageBox.Show("请选择登录类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboLogInType.Focus();
                return false;
            }
            else
            {
                return true;
            }            
        }  
    }
}
