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
    public partial class EmailNotify : Form
    {
        private int count;

        public EmailNotify()
        {
            InitializeComponent();
        }

        public EmailNotify(int count)
        {
            // TODO: Complete member initialization
            this.count = count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
