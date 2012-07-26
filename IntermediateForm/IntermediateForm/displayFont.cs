using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;

namespace IntermediateForm
{
    public partial class displayFont : Form
    {
        public displayFont()
        {
            InitializeComponent();
        }

        private void b_DisplayFonts_Click(object sender, EventArgs e)
        {
            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] ffs = ifc.Families;
            Font f;
            richTextBox1.Clear();
            foreach (FontFamily ff in ffs)
            {
                // 设置待写入文字的字体
                if (ff.IsStyleAvailable(System.Drawing.FontStyle.Regular))
                    f = new Font(ff.GetName(1), 12, System.Drawing.FontStyle.Regular);

                else if (ff.IsStyleAvailable(System.Drawing.FontStyle.Bold))

                    f = new Font(ff.GetName(1), 12, System.Drawing.FontStyle.Bold);
                else if (ff.IsStyleAvailable(System.Drawing.FontStyle.Italic))
                    f = new Font(ff.GetName(1), 12, System.Drawing.FontStyle.Italic);
                else
                    f = new Font(ff.GetName(1), 12, System.Drawing.FontStyle.Underline);

                // 注意：每次AppendText之前都设置字体
                richTextBox1.SelectionFont = f;
                richTextBox1.AppendText(ff.GetName(1) + "\r\n");
                richTextBox1.SelectionFont = f;
                richTextBox1.AppendText("abcdefghijklmnopqrstuvwxyz\r\n");
                richTextBox1.SelectionFont = f;
                richTextBox1.AppendText("ABCDEFGHIJKLMNOPQRSTUVWXYZ\r\n");

                richTextBox1.AppendText("===================================================\r\n");

            }

            MessageBox.Show("已把所有字体显示在文本框中", "成功", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

        }
    }
}
