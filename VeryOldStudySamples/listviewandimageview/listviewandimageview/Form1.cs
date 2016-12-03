using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace listviewandimageview
{
    public partial class Form1 : Form
    {

        public static string filepath = @"1.jpg";
        public FileStream std = new FileStream(filepath, FileMode.Open, FileAccess.Read);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem temp = new ListViewItem();
            temp.ImageKey = "temp";
            temp.Text = "asghfg";
            listView1.Items.Add(temp);

            Image img = Image.FromStream(std,true);
            imageList1.Images.Add("1.jpg",img);
            ListViewItem temp1 = new ListViewItem();
            temp1.ImageKey = "1.jpg";
            temp1.Text = "dasg";
            listView1.Items.Add(temp1);
        }
    }
}
