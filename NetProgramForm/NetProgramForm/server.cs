using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NetProgramForm
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {

            try
            {
                IPAddress ipAd = IPAddress.Parse("127.0.0.1");

                TcpListener myList = new TcpListener(ipAd,8001);

                myList.Start();

                tbserver.Text += "\r\n 在8001端口启动服务...";
                tbserver.Text =tbserver.Text+ "\r\n 本地节点为："+myList.LocalEndpoint;
                tbserver.Text += "\r\n 等待连接...";

                Socket s = myList.AcceptSocket();

                tbserver.Text = tbserver.Text + "\n 连接来自 " + s.RemoteEndPoint;

                byte[] b=new byte[100];
                int k = s.Receive(b);
                tbserver.Text += "\n 已接收...";
                for (int i = 0; i < k;i++ )
                {
                    tbserver.Text = tbserver.Text + "\n" + Convert.ToChar(b[i]);
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes("The string was recieve by the server."));
                tbserver.Text += "\n 已发送回应信息";

                s.Close();
                myList.Stop();
            }
            catch(Exception ee)
            {
                tbserver.Text = "Error"+ee.StackTrace;
            }
        }
    }
}
