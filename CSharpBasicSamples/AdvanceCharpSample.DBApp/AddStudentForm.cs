﻿using System;
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
    /// 新增学员用户窗体
    /// 第七章课堂案例示例1
    /// </summary>
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        
        // 关闭当前窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 当窗体加载时发生,示例1
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT GradeName FROM Grade"; // 查询年级的sql语句
            // 设置command命令执行的语句
            SqlCommand command = new SqlCommand(sql, DBHelper.connection); 

            try
            {
                DBHelper.connection.Open();  // 打开数据库连接
                SqlDataReader dataReader = command.ExecuteReader();// 执行查询

                string gradeName = "";  // 年级名称

                // 循环读出所有的年级名，并添加到年级列表框中
                while (dataReader.Read())
                {
                    gradeName = (string)dataReader["GradeName"];
                    cboGrade.Items.Add(gradeName);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.connection.Close();
            }
        }        
        
        /// <summary>
        /// 验证窗体输入
        /// </summary>
        /// <returns>验证成功返回True，失败返回False</returns>
        private bool ValidateInput()
        {
            if (txtLoginId.Text == "")  // 验证是否输入了用户名 
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginId.Focus();
                return false;
            }
            if (txtLoginPwd.Text == "")  // 验证是否输入了密码
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginPwd.Focus();
                return false;
            }
            if (txtPwdAgain.Text == "")  // 验证是否输入了确认密码
            {
                MessageBox.Show("请输入确认密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return false;
            }
            if (!(txtLoginPwd.Text == txtPwdAgain.Text))  // 验证两次密码是否一致
            {
                MessageBox.Show("两次输入的密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return false;
            }
            if (!rdoActive.Checked && !rdoInactive.Checked)  // 验证是否选择了用户状态
            {
                MessageBox.Show("请设置用户的状态", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdoActive.Focus();
                return false;
            }
            if (txtStudentName.Text == "")  // 验证是否输入了用户姓名
            {
                MessageBox.Show("请输入学员姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentName.Focus();
                return false;
            }
            if (txtStudentNO.Text == "")  // 验证是否输入了学号
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentNO.Focus();
                return false;
            }
            if (!rdoMale.Checked && !rdoFemale.Checked)  // 验证是否选择了性别
            {
                MessageBox.Show("请选择学员性别", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdoMale.Focus();
                return false;
            }
            if (cboClass.Text == "")  // 验证是否选择了用户的班级
            {
                MessageBox.Show("请选择用户班级", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboClass.Focus();
                return false;
            }
            return true;
        }
    }
}