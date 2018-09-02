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
            // 如果验证通过，就显示相应的用户窗体，并将当前窗体设为不可见
            if (ValidateInput())
            {  
                // 显示相应的窗体
                // 将输入的用户名保存到静态变量中
                UserHelper.loginId = txtLogInId.Text;
                // 将选择的登录类型保存到静态变量中
                UserHelper.loginType = cboLogInType.Text;

                ShowUserForm();  // 显示相应用户的主窗体

                this.Visible = false;                
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

        /// <summary>
        /// 根据登录类型，显示相应的窗体
        /// </summary>
        public void ShowUserForm()
        {
            switch (cboLogInType.Text)
            {
                // 如果是学员，显示学员窗体
                case "学员":
                    MessageBox.Show("抱歉，您请求的功能尚未完成！");
                    break;
                // 如果是教员，显示教员窗体
                case "教员":
                    MessageBox.Show("抱歉，您请求的功能尚未完成！");
                    break;
                // 如果是管理员，显示管理员窗体
                case "管理员":
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                default:
                    MessageBox.Show("抱歉，您请求的功能尚未完成！");
                    break;
            }
        }
    }
}
