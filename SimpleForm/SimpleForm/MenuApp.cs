using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleForm
{
    public partial class MenuApp : Form
    {
        public MenuApp()
        {
            InitializeComponent();
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void ViewYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void ViewBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void HelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guanyu");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Equals((object)toolStripViewRed))
            {
                this.ViewRed_Click(sender,e);
            }
            else if(e.ClickedItem.Equals((object)toolStripViewBlue))
            {
                this.ViewBlue_Click(sender,e);
            }
            else if(e.ClickedItem.Equals((object)toolStripViewYellow))
            {
                this.ViewYellow_Click(sender,e);
            }
            else if(e.ClickedItem.Equals((object)toolStripFileExit))
            {
                this.FileExit_Click(sender,e);
            }
            else if(e.ClickedItem.Equals((object)toolStripHelpAbout))
            {
                this.HelpAbout_Click(sender,e);
            }
        }

        
    }
}
