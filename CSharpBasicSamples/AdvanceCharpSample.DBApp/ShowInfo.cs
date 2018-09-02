using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace ConnectionAccess
{
    public partial class ShowInfo : Form
    {
        private DataSet ds;
        private OleDbDataAdapter dataAdapter;

        public ShowInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载时，显示所有的数据
        /// </summary>
        private void ShowInfo_Load(object sender, EventArgs e)
        {
            SearchInfo(null);                          //调用方法查询所有的数据
        }

        /// <summary>
        /// 查询数据库中数据的方法
        /// </summary>
        /// <param name="sql"></param>
        private void SearchInfo(string sql) 
        {
            //判断用户传入的sql语句是否为空，为空则赋予其一个查询语句
            if (sql == null) 
            {
                sql = "select * from student";
            }

            try
            {
                //打开数据库连接
                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }
                //创建dataAdapter对象
                dataAdapter = new OleDbDataAdapter(sql,DBHelper.connection);
                //创建dataset对象
                ds = new DataSet();
                //填充数据
                dataAdapter.Fill(ds, "studentInfo");
                //向dataGridView中填充数据
                dgvShow.DataSource = ds.Tables["studentInfo"];
            }
            catch (Exception es)
            {
                //打印异常信息
                MessageBox.Show(es.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
               DBHelper.connection.Close();          //关闭数据库连接
            }
        }

        /// <summary>
        /// 点击关闭后关闭给窗体
        /// </summary>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit();                 //退出程序
        }

        /// <summary>
        /// 点击查询后，按用户的需求查找数据
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //创建查询语句，是按用户输入的字符作为模糊查询的条件查询
            string sql = string.Format("select * from student where LoginID like '%{0}%'",txtFont.Text.Trim());
            //调用方法查询用户所需的信息
            SearchInfo(sql);

            go();
        }

        /// <summary>
        /// 根据用户修改的内容创建更新的sql语句
        /// </summary>
        /// <returns>sql语句</returns>
        private string Sql() 
        {
            //获被修改行信息
            int studentID = (int)dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colstudentID"].Value;
            string loginID = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colLoginID"].Value.ToString();
            int loginPwd = (int)dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colloginPwd"].Value;
            int state = (int)dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["coluserStateID"].Value;
            int classID = (int)dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colClassID"].Value;
            string studentNo = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colStudentNo"].Value.ToString();
            string name = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colStudentName"].Value.ToString();
            string sex = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colSex"].Value.ToString();
            string mojar = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colMajor"].Value.ToString();
            int phone = (int)dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colPhone"].Value;
            string address = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colAddress"].Value.ToString();
            string email = dgvShow.Rows[dgvShow.CurrentCell.RowIndex].Cells["colEmail"].Value.ToString();

            //sql语句
           string sql =string.Format(@"update student set loginID='{0}',loginPwd={1},userStateID={2},classID={3},
                                   studentNo='{4}',studentName='{5}',Sex='{6}',major='{7}',phone={8},address='{9}',email='{10}'
                                   where studentID={11}
                                ",loginID,loginPwd,state,classID,studentNo,name,sex,mojar,phone,address,email,studentID);
           return sql;
        } 

        /// <summary>
        /// 点击保存后保存用户修改后的信息
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //打开数据库连接
                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }
                //执行sql语句
                int num = new OleDbCommand(Sql(), DBHelper.connection).ExecuteNonQuery();
                //如果影响的行数不为一，则提时更新失败
                if (num != 1)
                {
                    MessageBox.Show("保存失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else //否则提示更新成功，并更新信息 
                {
                    MessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SearchInfo(null);                          //调用方法查询所有的数据
                }
            }
            catch (Exception es)
            {
                //打印异常信息
                MessageBox.Show(es.Message, "异常信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DBHelper.connection.Close();          //关闭数据库连接
            }
        }

        private void go() 
        {
            string sql = string.Format("select Photos from Student where LoginID like '%{0}%'",txtFont.Text.Trim());

            try
            {
                //如果数据库连接状态为关闭状态，则打开数据库连接
                if (DBHelper.connection.State == ConnectionState.Closed)
                {
                    DBHelper.connection.Open();
                }
                //将数据库中的二进制存储到数组中
                byte[] photos = (byte[])(new OleDbCommand(sql, DBHelper.connection)).ExecuteScalar();
                //判断读取的数据是否是为空，不是为空，则将图片的二进制转换成图片显示出来！！
                if (photos.Length > 0)
                {
                    MemoryStream stream = new MemoryStream(photos, true);
                    stream.Write(photos, 0, photos.Length);
                    picPhotos.Image = new Bitmap(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally 
            {
                DBHelper.connection.Close();
            }
        }
    }
}
