using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace NetProgramForm
{
    public partial class client : Form
    {
        TcpClient tcpclnt = new TcpClient();
        public client()
        {
            InitializeComponent();
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                tbclient.Text = "连接...... \n";

                tcpclnt.Connect("127.0.0.1",8001);
                tbclient.Text += "已连接 \n";
                tbclient.Text += "请输入要传输的字符串：";
                this.btnsend_Click(sender,e);

            }
            catch(Exception ee)
            {
                tbclient.Text = "Error......"+ee.StackTrace;
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            Stream stm = tcpclnt.GetStream();
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(tbinput.Text);
            tbclient.Text += tbinput.Text;
            tbclient.Text += "\n 传输中.....";
            stm.Write(ba,0,ba.Length);

            byte[] bb=new byte[100];
            int k = stm.Read(bb,0,100);

            for (int i=0; i < k;i++ )
            {
                tbclient.Text = tbclient.Text + Convert.ToChar(bb[i]);
            }

            tcpclnt.Close();
        }
    }
}
