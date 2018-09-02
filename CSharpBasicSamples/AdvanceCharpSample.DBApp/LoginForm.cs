using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySchool
{
    /// <summary>
    /// 登录窗体
    /// 第6章课堂案例示例4
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // 单击“取消”按钮，关闭应用程序
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // 单击“登录”按钮时，设置用户名和登录类型
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isValidUser = false;   // 标识是否为合法用户
            string message = "";        // 如果登录失败，显示的消息提示

            // 如果验证通过，就显示相应的用户窗体，并将当前窗体设为不可见
            if (ValidateInput())
            {
                // 调用用户验证方法
                isValidUser = ValidateUser( 
                    cboLogInType.Text, 
                    txtLogInId.Text, 
                    txtLogInPwd.Text, 
                    ref message);
                
                // 如果是合法用户，显示相应的窗体
                if (isValidUser) 
                {
                    // 将输入的用户名保存到静态变量中
                    UserHelper.loginId = txtLogInId.Text;
                    // 将选择的登录类型保存到静态变量中
                    UserHelper.loginType = cboLogInType.Text;  

                    ShowUserForm();  // 显示相应用户的主窗体

                    this.Visible = false;
                }
                // 如果登录失败，显示相应的消息
                else
                {
                    MessageBox.Show(message, "登录失败",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        // 验证用户是否进行了输入和选择       
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

        // 验证用户输入的用户名和密码是否正确
        // 验证的结果有两种情况：通过和不通过，返回值为布尔型
        // 不通过的原因可能有多种，在方法的参数中的message字符串，用以标识不通过的情况        
        public bool ValidateUser(string loginType, string loginId, string loginPwd, ref string message)
        {
            return true;
        }

        // 根据登录类型，显示相应的窗体
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
