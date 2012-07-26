using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace IntermediateForm
{
    public partial class imageConvert : Form
    {

        private Bitmap m_bitmap;
        private int m_width0;
        private int m_height0;

        public imageConvert()
        {
            InitializeComponent();

            m_bitmap = null;
            m_width0 = pictureBox1.Size.Width;
            m_height0 = pictureBox1.Size.Height;
        }

        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = cmbOpenFiletype.Text + "|" + cmbOpenFiletype.Text;
            string filter = ofd.Filter;
            ofd.InitialDirectory = System.Environment.CurrentDirectory;
            ofd.Title = "打开图像文件";
            ofd.ShowHelp = true;
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                string strFileName = ofd.FileName;
                m_bitmap = new Bitmap(strFileName);
                if (m_bitmap.Width > m_bitmap.Height)
                {
                    pictureBox1.Width = m_width0;
                    pictureBox1.Height = (int)((double)m_bitmap.Height * m_width0 / m_bitmap.Width);
                }
                else
                {
                    pictureBox1.Height = m_height0;
                    pictureBox1.Width=(int)((double)m_bitmap.Width*m_height0/m_bitmap.Height);
                }

                pictureBox1.Image = m_bitmap;
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "图象另存为";
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            sfd.Filter = cmbSaveFiletype.Text + "|" + cmbSaveFiletype.Text;
            sfd.ShowHelp = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strFileName = sfd.FileName;
                switch (cmbSaveFiletype.Text)
                {
                    case "*.bmp":
                        m_bitmap.Save(strFileName, ImageFormat.Bmp);
                        break;

                    case "*.jpg":
                        m_bitmap.Save(strFileName, ImageFormat.Jpeg);
                        break;

                    case "*.gif":
                        m_bitmap.Save(strFileName, ImageFormat.Gif);
                        break;

                    case "*.tif":
                        m_bitmap.Save(strFileName, ImageFormat.Tiff);
                        break;
                }
                MessageBox.Show("图象文件格式转换成功！", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
