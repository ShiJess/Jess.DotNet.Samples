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
    public partial class addCtrlAtRuntimeApp : Form
    {
        private int count;
        public addCtrlAtRuntimeApp()
        {
            InitializeComponent();
        }

        private void btn_addButtons_Click(object sender, EventArgs e)
        {
            count++;

            int localY = this.btn_addButtons.Height * count;
            int localX = 10 * count;

            Button toAddButton = new Button();

            toAddButton.Name = "Button" + count;
            toAddButton.Text = "按钮" + count + "";
            toAddButton.Location = new Point(localX,localY);

            toAddButton.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            toAddButton.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            toAddButton.Click += new System.EventHandler(this.btn_Click);

            this.Controls.Add(toAddButton);
        }

        private void btn_MouseEnter(object sender, System.EventArgs e)
        {
            Button currentButton = (Button)sender;

            currentButton.BackColor = Color.Blue; ;
        }

        private void btn_MouseLeave(object sender, System.EventArgs e)
        {
            Button currentButton = (Button)sender;

            currentButton.BackColor = System.Windows.Forms.Control.DefaultBackColor;
        }

        private void btn_Click(object sender, System.EventArgs e)
        {
            Button currentButton = (Button)sender;

            txt_msg.Text = "你点击了" + currentButton.Text;
        }
    }
}
