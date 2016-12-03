using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IntermediateForm
{
    public partial class htmlMaker : Form
    {
        private string name = "";
        private string filename = "";
        private StreamWriter writer = null;
        public htmlMaker()
        {
            InitializeComponent();
        }

        private void btnGeneraleCode_Click(object sender, EventArgs e)
        {
            name = txbName.Text.Trim();
            filename = txbFilename.Text.Trim();

            if ((txbName.Text == "") || (txbFilename.Text == ""))
            {
                stbMsg.Text = "请先输入\"姓名\"和\"文件名\"";
                txbName.Focus();
            }
            else
            {
                if (GenerateCode())
                {
                    stbMsg.Text = "已创建文件" + filename;
                }
                else
                {
                    stbMsg.Text = "创建文件失败！";
                }
            }
        }


        private bool GenerateCode()
        {
            // 文件存在时是否覆盖
            FileInfo f = new FileInfo(filename);
            if (f.Exists)
            {
                DialogResult s = MessageBox.Show("该文件已经存在，是否覆盖？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (String.Format("{0}", s) == "Yes")
                {
                    f.Delete();
                }
                else
                {
                    s = MessageBox.Show("请输入不同的文件名！", "警告");
                    txbFilename.Focus();
                    return false;
                }
            }

            // 写文件
            FileStream outputfile = null;
            try
            {
                outputfile = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(outputfile);
                writer.BaseStream.Seek(0, SeekOrigin.End);
                DoWrite("<HTML>");
                DoWrite("<HEAD>");
                DoWrite("<TITLE>");
                DoWrite(name + "介绍");
                DoWrite("</TITLE>");
                DoWrite("</HEAD>");
                DoWrite("<BODY BGCOLOR='Tan'>");
                DoWrite("<CENTER>");
                DoWrite("<BR><BR><H2>欢迎参观 " + name + "的页面</H2>");
                DoWrite("<BR><H4><A HREF='http://www.myclass.com'>校友录首页</A></H4>");
                DoWrite("</CENTER>");
                DoWrite("</BODY>");
                DoWrite("</HTML>");
                writer.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception GenerateCode = " + ex);
                stbMsg.Text = "Error";
                outputfile = null;
                writer = null;
                return false;
            }
            return true;
        }

        private void DoWrite(String line)
        {
            writer.WriteLine(line);
            writer.Flush();
        }


        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txbName.Text = "";
            txbFilename.Text = "";
            stbMsg.Text = "清空所有输入框";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
