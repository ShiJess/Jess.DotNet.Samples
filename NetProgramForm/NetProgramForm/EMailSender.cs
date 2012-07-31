using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Web;
//using System.Web.Mail;
using System.Net;
using System.Net.Mail;

namespace NetProgramForm
{
    public partial class EMailSender : Form
    {
        public EMailSender()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage aMessage = new MailMessage(FromTextBox.Text, ToTextBox.Text);
                //aMessage.From=(MailAddress)FromTextBox.Text;
                //aMessage.To = ToTextBox.Text;
                aMessage.CC.Add(CCTextBox.Text);
                aMessage.Bcc.Add(BCCTextBox.Text);
                aMessage.Subject = SubjectTextBox.Text;
                aMessage.Body = MessageTextBox.Text;
                if (AttachmentTextBox.Text.Length > 0)
                {
                    Attachment data = new Attachment(AttachmentTextBox.Text);
                    aMessage.Attachments.Add(data);
                }
                SmtpClient sm=new SmtpClient();
                sm.Send(aMessage);
                MessageBox.Show("邮件发送成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                AttachmentTextBox.Text = this.openFileDialog1.FileName;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
