using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace NetProgramForm
{
    public partial class Webbrowse : Form
    {
        private System.Windows.Forms.SaveFileDialog savefile = new SaveFileDialog();
        private WebClient client = new WebClient();
        public Webbrowse()
        {
            InitializeComponent();
        }

        private void rddownload_Click(object sender, EventArgs e)
        {
            if(rddownload.Checked==true)
            {
                btn.Text = "开始下载";
            }
            if(rdupload.Checked==true)
            {
                btn.Text = "开始上载";
            }
            if(rddataload.Checked==true)
            {
                btn.Text = "开始数据下载";
            }
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            btn.Enabled = true;
            savefile.Filter = "Html(*.html)|*.html|All Files(*.*)|*.*";
            savefile.Title = "另存为";
            if(txtbrowse.Text=="")
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    txtbrowse.Text = savefile.FileName;
                }
                else
                {
                    MessageBox.Show("未选择文件....","警告");
                }
            }
        }

        private void btnres_Click(object sender, EventArgs e)
        {
            string URL = textbox1.Text;
            try
            {
                WebRequest myre = WebRequest.Create(URL);
            }
            catch(WebException exp)
            {
                MessageBox.Show(exp.Message,"错误");
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string URL = textbox1.Text;

            if(rddownload.Checked==true)
            {
                try
                {
                    this.Text = URL + "......下载中";
                    btn.Text = "开始下载";
                    client.DownloadFile(URL,txtbrowse.Text);
                    MessageBox.Show("下载成功......","成功");
                    this.Text = "D/U Loader";
                }
                catch(WebException exp)
                {
                    MessageBox.Show(exp.Message,"错误");
                }
            }
            else if(rdupload.Checked==true)
            {

                try
                {
                    client.UploadFile(URL,txtbrowse.Text);
                    this.Text = URL + ".....上载中";
                    this.Text = "上/下载网页";
                }
                catch(WebException exp)
                {
                    MessageBox.Show(exp.Message,"错误");
                }
            }
            else if(rddataload.Checked==true)
            {
                try
                {
                    this.Text = URL + "......数据下载中";
                    Stream data = client.OpenRead(URL);
                    StreamReader reader = new StreamReader(data);
                    byte[] mybyte = new byte[100000];
                    int allbyte = (int)mybyte.Length;
                    int startbyte = 0;
                    while (allbyte > 0)
                    {
                        int n = data.Read(mybyte, startbyte, allbyte);
                        if (n == 0)
                        {
                            break;
                        }
                        allbyte = n;
                        startbyte += n;
                    }
                    FileStream filestr = new FileStream(txtbrowse.Text, FileMode.OpenOrCreate, FileAccess.Write);
                    filestr.Write(mybyte,0,startbyte);

                    data.Close();
                    filestr.Close();
                    MessageBox.Show("下载结束....","成功");
                    this.Text = "上/下载网页";
                }
                catch(WebException exp)
                {
                    MessageBox.Show(exp.Message,"错误");
                }
            }
        }
    }
}
