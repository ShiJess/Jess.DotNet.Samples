using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetProgramForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exemple63_Click(object sender, EventArgs e)
        {
            EMailSender frm = new EMailSender();
            frm.ShowDialog();
        }

        private void Exemple64_Click(object sender, EventArgs e)
        {
            EmailNotifier frm=new EmailNotifier();
            //frm.ShowDialog();
           // Application.Run(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Webbrowse frm = new Webbrowse();
            frm.ShowDialog();
        }

        
    }
}
