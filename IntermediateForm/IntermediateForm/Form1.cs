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

        private void Exemple43_Click(object sender, EventArgs e)
        {
            Calculator frm = new Calculator();
            frm.ShowDialog();
        }

        private void Exemple44_Click(object sender, EventArgs e)
        {
            transparentWindow frm = new transparentWindow();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            htmlMaker frm = new htmlMaker();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageConvert frm = new imageConvert();
            frm.ShowDialog();
        }

        private void Exemple47_Click(object sender, EventArgs e)
        {
            textSearch frm = new textSearch();
            frm.ShowDialog();
        }

        private void Exemple48_Click(object sender, EventArgs e)
        {
            displayFont frm = new displayFont();
            frm.ShowDialog();
        }

        private void Exemple49_Click(object sender, EventArgs e)
        {
            MTHForm frm = new MTHForm();
            frm.ShowDialog();
        }

        private void Exemple50_Click(object sender, EventArgs e)
        {
            pingtu frm = new pingtu();
            frm.ShowDialog();
        }
    }
}
