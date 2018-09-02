using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MySchool
{
    /// <summary>
    /// About窗体
    /// </summary>
    public partial class AboutForm : Form
    {
        int index = 0;  // 图片框中图片的索引
        
        public AboutForm()
        {
            InitializeComponent();
        }
        
        // 计时器的事件处理方法，定时变换图片框中的图片
        private void timer_Tick(object sender, EventArgs e)
        {
            // 如果当前显示的图片索引没有到最大值就继续增加
            if (index < ilAnimation.Images.Count - 1)
            {
                index++;
            }
            else  // 否则从第一个图片开始显示，索引从0开始
            {
                index = 0;            
            }
            // 设置图片框显示的图片   
            picAnimation.Image = ilAnimation.Images[index];
        }

        // 图片框的单击事件处理方法，单击时关闭窗体
        private void picOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}