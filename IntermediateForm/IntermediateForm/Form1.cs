using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntermediateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exemple42_Click(object sender, EventArgs e)
        {
            addCtrlAtRuntimeApp frm = new addCtrlAtRuntimeApp();
            frm.ShowDialog();
        }
    }
}
