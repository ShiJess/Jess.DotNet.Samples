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

        private void Exemple51_Click(object sender, EventArgs e)
        {
            server frm = new server();
            frm.ShowDialog();
        }

        private void Exemple52_Click(object sender, EventArgs e)
        {
            client frm = new client();
            frm.ShowDialog();
        }

        
    }
}
