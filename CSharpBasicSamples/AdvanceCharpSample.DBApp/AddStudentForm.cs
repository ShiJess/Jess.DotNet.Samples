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
    /// 新增学员用户窗体
    /// 第七章课堂案例示例2
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

        // 增加学员信息到数据库，示例2
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // 获取要插入数据库的每个字段的值
                string loginId = txtLoginId.Text;   // 用户名
                string loginPwd = txtLoginPwd.Text; // 密码

                // 根据选择的状态设置状态id
                string userStateId = rdoActive.Checked ? (string)rdoActive.Tag : (string)rdoInactive.Tag;

                string name = txtStudentName.Text;     // 姓名
                string studentNO = txtStudentNO.Text;  // 学号
                string phone = txtPhone.Text;          // 电话
                string email = txtEmail.Text;          // 电子邮件

                string sex = rdoMale.Checked ? rdoMale.Text : rdoFemale.Text; // 性别

                // 调用获取班级id的方法，获取班级id
                int classId = GetClassId();

                // 构建插入的sql语句
                string sql = string.Format("INSERT INTO Student (LoginId,LoginPwd,UserStateId,ClassID,StudentName,Sex,Phone,StudentNO,Email) values('{0}','{1}','{2}',{3},'{4}','{5}','{6}','{7}','{8}')",
                    loginId, loginPwd, userStateId, classId, name, sex, phone, studentNO, email);

                try
                {
                    SqlCommand command = new SqlCommand(sql, DBHelper.connection);  // 创建command对象
                    DBHelper.connection.Open();  // 打开数据库连接

                    int result = command.ExecuteNonQuery();  // 执行命令

                    // 根据操作结果给出提示信息
                    if (result < 1)
                    {
                        MessageBox.Show("添加失败！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }                    
                    else
                    {
                        MessageBox.Show("添加成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("操作数据库出错！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    DBHelper.connection.Close();  // 关闭数据库连接
                } 
            }                       
        }
        
        // 当窗体加载时发生
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

        // 当选择的年级变化时，变化班级组合框的选项
        // 不在课上实现，做为课程的扩展
        private void cboGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrade.Text.Trim() != "")
            {
                // 先找出年级的id
                int gradeId = -1;
                // 查询GradeID 的sql语句
                string sql = "SELECT GradeId FROM Grade WHERE GradeName='" + cboGrade.Text + "'"; 
                // 定义command对象
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);  
                SqlDataReader dataReader;
                try
                {
                    DBHelper.connection.Open();
                    dataReader = command.ExecuteReader();// 执行查询

                    // 循环读出所有的班级名，并添加到班级组合框中
                    if (dataReader.Read())
                    {
                        gradeId = (int)dataReader["GradeId"];
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

                // 根据年级Id查询班级名称的sql语句
                sql = "SELECT ClassName FROM Class WHERE GradeId=" + gradeId; 
                command.CommandText = sql;  //重新指定command对象的查询语句

                try
                {
                    DBHelper.connection.Open();
                    dataReader = command.ExecuteReader();// 执行查询

                    string className = "";   // 班级名称
                    cboClass.Items.Clear();  // 清除原有值

                    // 循环读出所有的班级名，并添加到班级组合框中
                    while (dataReader.Read())
                    {
                        className = (string)dataReader["ClassName"];
                        cboClass.Items.Add(className);
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

        /// <summary>
        /// 获取班级id
        /// </summary>
        /// <returns>返回班级组合框中选中的班级的Id值</returns>
        private int GetClassId()
        {
            int classId = 0;  // 班级名称
            string sql = string.Format("SELECT ClassID FROM Class WHERE ClassName='{0}'", cboClass.Text);

            try
            {
                SqlCommand command = new SqlCommand(sql, DBHelper.connection);   // 定义command对象            
                DBHelper.connection.Open();  // 打开数据库连接
                SqlDataReader dataReader = command.ExecuteReader();// 执行查询                

                // 读出班级id
                if (dataReader.Read())
                {
                    classId = (int)dataReader[0];
                }

                dataReader.Close();  // 关闭 DataReader 对象
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据库出错");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                DBHelper.connection.Close();  // 关闭数据库连接
            }
            return classId;
        }        
    }
}
