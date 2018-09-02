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
    /// 学员信息列表窗体
    /// </summary>
    public partial class StudentListForm : Form
    {
        DataSet dataSet = new DataSet("MySchool");  // 创建 DataSet 对象
        SqlDataAdapter dataAdapter;  　　           // 声明一个数据适配器对象

        public StudentListForm()
        {
            InitializeComponent();
        }

        // 窗体加载事件处理，加载时填充数据集，显示数据
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            // 查询用的 sql 语句
            string sql = "SELECT StudentId, LoginId, StudentName, StudentNO, Sex, Phone, Address, JobWanted FROM Student";
            // 创建 DataAdapter 对象
            dataAdapter = new SqlDataAdapter(sql, DBHelper.connection);
            // 填充数据集
            dataAdapter.Fill(dataSet, "Student");

            // 指定 DataGridView 数据源，显示数据
            dgvStudent.DataSource = dataSet.Tables["Student"];

            // 设置筛选条件的默认值
            cboSex.Text = "全部";
        }

        // “保存修改”按钮 Click 事件处理，将数据提交给数据库
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "确定要保存修改吗？", "操作提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)  // 确认修改
            {
                // 自动生成更新数据用的命令
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                // 将修改过的数据提交到数据库
                dataAdapter.Update(dataSet, "Student");
            }
        }

        // “筛选”按钮的 Click 事件处理，组合SQL语句，重新填充数据集
        private void btnReFill_Click(object sender, EventArgs e)
        {
            // 基本 SQL 语句
            string sql = "SELECT StudentId, LoginId, StudentName, StudentNO, Sex, Phone, Address, JobWanted FROM Student";

            // 根据组合框的选择组合 SQL 语句
            switch (cboSex.Text)
            {
                case "男":  // 增加性别为男的条件
                    sql += " WHERE Sex = '男'";
                    break;
                case "女": // 增加性别为女的条件
                    sql += " WHERE Sex = '女'";
                    break;
                default:   // 不做任何操作
                    break;
            }

            dataSet.Tables["Student"].Clear();

            // 重新指定 DataAdapter 对象的查询语句
            dataAdapter.SelectCommand.CommandText = sql;
            // 重新填充数据集
            dataAdapter.Fill(dataSet, "Student");
        }

        // 关闭按钮事件处理，关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // “刷新”按钮的 Click 事件处理，重新填充数据集并显示
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // 查询用的 sql 语句
            string sql = "SELECT StudentId, LoginId, StudentName, StudentNO, Sex, Phone, Address, JobWanted FROM Student";

            cboSex.Text = "全部";
            dataSet.Tables["Student"].Clear(); // 清空原来的表

            // 创建 DataAdapter 对象
            dataAdapter.SelectCommand.CommandText = sql;
            
            // 填充数据集
            dataAdapter.Fill(dataSet, "Student");
        }
    }
}