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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exemple21_Click(object sender, EventArgs e)
        {
            myFirstWinApp frm = new myFirstWinApp();
            frm.ShowDialog();
        }

        private void Exemple22_Click(object sender, EventArgs e)
        {
            imageView frm = new imageView();
            frm.ShowDialog();
        }

        private void Exemple23_Click(object sender, EventArgs e)
        {
            myfirstapp0 frm = new myfirstapp0();
            frm.ShowDialog();
        }

        private void Exemple24_Click(object sender, EventArgs e)
        {
            myfristwinapp0 frm = new myfristwinapp0();
            frm.ShowDialog();
        }

        private void Exemple25_Click(object sender, EventArgs e)
        {
            MenuApp frm = new MenuApp();
            frm.ShowDialog();
        }

        private void Exemple26_Click(object sender, EventArgs e)
        {
            MenuApp frm = new MenuApp();
            frm.ShowDialog();
        }

        private void Exemple27_Click(object sender, EventArgs e)
        {
            ClockFrom frm = new ClockFrom();
            frm.ShowDialog();
        }

        private void Exemple29_Click(object sender, EventArgs e)
        {
            useIPBox frm = new useIPBox();
            frm.ShowDialog();
        }

        private void Exemple30_Click(object sender, EventArgs e)
        {
            useTreeView frm = new useTreeView();
            frm.ShowDialog();
        }

        private void Exemple31_Click(object sender, EventArgs e)
        {
            FolderDialog frm = new FolderDialog();
            frm.ShowDialog();
        }

        private void Exemple32_Click(object sender, EventArgs e)
        {
            progBarApp frm = new progBarApp();
            frm.ShowDialog();
        }

        private void Exemple33_Click(object sender, EventArgs e)
        {
            controlTipApp frm = new controlTipApp();
            frm.ShowDialog();
        }

        private void Exemple34_Click(object sender, EventArgs e)
        {
            TrayIcon frm = new TrayIcon();
            frm.ShowDialog();
        }

        private void Exemple35_Click(object sender, EventArgs e)
        {
            noBorderApp frm = new noBorderApp();
            frm.ShowDialog();
        }

        private void Exemple36_Click(object sender, EventArgs e)
        {
            MDIFormApp frm = new MDIFormApp();
            frm.ShowDialog();
        }

        private void Exemple37_Click(object sender, EventArgs e)
        {
            floatingForm frm = new floatingForm();
            frm.ShowDialog();
        }

        private void Exemple38_Click(object sender, EventArgs e)
        {
            checklistBoxApp frm = new checklistBoxApp();
            frm.ShowDialog();
        }

        private void Exemple39_Click(object sender, EventArgs e)
        {
            testApp frm = new testApp();
            frm.ShowDialog();
        }

        private void Exemple40_Click(object sender, EventArgs e)
        {
            useSplitterApp frm = new useSplitterApp();
            frm.ShowDialog();
        }

        private void ExitTheProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
