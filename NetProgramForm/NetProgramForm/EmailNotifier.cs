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
using System.IO;


namespace NetProgramForm
{
    public partial class EmailNotifier : Form
    {
        NetworkStream netStream;
        EmailNotify emailnot;
        public EmailNotifier()
        {
            InitializeComponent();
           
            this.Opacity = 0;
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkForError(String strMessage)
        {
            if (strMessage.IndexOf("+OK") == -1)
                throw new Exception("ERROR - . Recieved: " + strMessage);
        }

        private String ReadFromNetStream(ref NetworkStream NetStream)
        {
            StringBuilder strReceived = new StringBuilder();
            StreamReader sr = new StreamReader(NetStream);
            String strLine = sr.ReadLine();

            while (strLine == null || strLine.Length == 0)
            {
                strLine = sr.ReadLine();
            }
            strReceived.Append(strLine);

            if (sr.Peek() != -1)
            {
                while ((strLine = sr.ReadLine()) != null)
                {
                    strReceived.Append(strLine);
                }
            }
            return strReceived.ToString();
        }

        private void WriteToNetStream(ref NetworkStream NetStream, string Command)
        {
            string stringToSend = Command + "\r\n";

            Byte[] arrayToSend = Encoding.ASCII.GetBytes(stringToSend.ToCharArray());
            NetStream.Write(arrayToSend, 0, arrayToSend.Length);
        }

        public void Stat()
        {

            WriteToNetStream(ref netStream, "STAT");

            string returnMsg = ReadFromNetStream(ref netStream);
            checkForError(returnMsg);

            ///split the information of total message and total size
            string[] TotalStat = returnMsg.Split(new char[] { ' ' });

            int count = Int32.Parse(TotalStat[1]);
            int totalSize = Int32.Parse(TotalStat[2]);
            emailnot = new EmailNotify(count);


            emailnot.Show();

        }

        private void EmailCheck()
        {
            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.Connect(txtPopServer.Text, Int32.Parse(txtPopPort.Text));
            }
            catch
            {
                MessageBox.Show("Cannot connect to target host "+txtPopServer.Text+" and port "+txtPopPort.Text);
            }
            netStream = tcpClient.GetStream();
            if(netStream==null)
            {
                throw new Exception("GetStream is null");
            }

            string returnMsg = ReadFromNetStream(ref netStream);

            checkForError(returnMsg);

            ///send username information
            WriteToNetStream(ref netStream, "USER " + this.txtUserName.Text);

            returnMsg = ReadFromNetStream(ref netStream);
            checkForError(returnMsg);

            ///send password information
            WriteToNetStream(ref netStream, "PASS " + this.txtPassword.Text);

            returnMsg = ReadFromNetStream(ref netStream);
            checkForError(returnMsg);

            Stat();

            netStream.Close();
            tcpClient.Close();

            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            EmailCheck();
        }

        private void btnCheckMail_Click(object sender, EventArgs e)
        {
            EmailCheck();
        }

        private void menuItem2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailCheck();
        }

        private void menuItem1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
