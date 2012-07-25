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
    public partial class checklistBoxApp : Form
    {
        public checklistBoxApp()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (NewValue.Text.Trim() != "")
            {
                checkedListBox1.Items.Add(NewValue.Text);
                NewValue.Text = "";
            }
            else
            {
                MessageBox.Show("请输入一个字符串！");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("请选中待删除的项！");
            }
        }

        private void ShowValues_Click(object sender, EventArgs e)
        {
            string SelectedValues = "以下值被选中：\n" + new String('-',48) + "\n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count;i++ )
            {
                SelectedValues += checkedListBox1.CheckedItems[i].ToString() + "\n";
            }
            MessageBox.Show(SelectedValues);
        }
    }
}
