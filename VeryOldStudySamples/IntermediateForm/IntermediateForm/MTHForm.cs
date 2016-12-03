using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IntermediateForm
{
    public partial class MTHForm : Form
    {
        private const int BUTTON_COUNT = 25; //按钮数量(平方数 16,25,36,49,...)
        private int SQUARE_ROOT = Convert.ToInt32(Math.Sqrt(BUTTON_COUNT)); //按钮数量的平方根
        private int PART_COUNT = 2 * Convert.ToInt32(Math.Sqrt(BUTTON_COUNT)) + 1;
        private Button[] btn = new Button[BUTTON_COUNT]; //按钮数组
        private Label lblAim;

        private int count = 0;
        private string step = "";


        public MTHForm()
        {
            InitializeComponent();
            //
            // 设置窗体属性
            //
            this.Left = 0;
            this.Top = 0;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Text = "满堂红";

            //
            // 把所有按钮布置到窗体上
            //
            for (int i = 0; i < BUTTON_COUNT; i++)
            {
                btn[i] = new Button();
                btn[i].Width = this.ClientSize.Width / PART_COUNT;
                btn[i].Height = this.ClientSize.Height / PART_COUNT;
                btn[i].Left = this.ClientSize.Width / PART_COUNT + 2 * (i % SQUARE_ROOT) * this.ClientSize.Width / PART_COUNT;
                btn[i].Top = this.ClientSize.Height / PART_COUNT + 2 * (i / SQUARE_ROOT) * this.ClientSize.Height / PART_COUNT;
                btn[i].BackColor = Color.SeaGreen;
                btn[i].Text = Convert.ToString(i + 1);
                btn[i].Click += new EventHandler(btn_Click); //给按钮添加事件		
                btn[i].Tag = 0;
                this.Controls.Add(btn[i]);
            }

            //
            // Label
            //
            lblAim = new Label();
            lblAim.Width = this.ClientSize.Width;
            lblAim.Text = "请把所有按钮变红!  要快哦!";
            this.Controls.Add(lblAim);
        }



        public void btn_Click(object sender, EventArgs eArgs)
        {
            int i = Convert.ToInt32(((Button)sender).Text) - 1;
            ChangeButtonState(i); //被点击的按钮
            ChangeButtonState((i / SQUARE_ROOT) * SQUARE_ROOT + (i + 1) % SQUARE_ROOT); //右边按钮
            ChangeButtonState((i / SQUARE_ROOT) * SQUARE_ROOT + (i + SQUARE_ROOT - 1) % SQUARE_ROOT); //左边按钮
            ChangeButtonState((i + SQUARE_ROOT) % BUTTON_COUNT); //下边按钮
            ChangeButtonState((i - SQUARE_ROOT + BUTTON_COUNT) % BUTTON_COUNT); //上边按钮

            count++;
            step += (i + 1).ToString() + " ";

            //检查是否所有按钮的颜色都已经变红了
            if (CheckForWin() == true)
            {
                WonTheGame();
            }
        }

        //
        // 改变按钮状态
        //
        private void ChangeButtonState(int i)
        {
            if (Convert.ToInt32(btn[i].Tag) == 0)
            {
                btn[i].Tag = 1;
                btn[i].BackColor = Color.Red;
            }
            else
            {
                btn[i].Tag = 0;
                btn[i].BackColor = Color.SeaGreen;
            }
        }

        //
        // 检查是否所有的按钮颜色变红了
        //
        private bool CheckForWin()
        {
            for (int i = 0; i < BUTTON_COUNT; i++)
            {
                if (Convert.ToInt32(btn[i].Tag) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //
        // 赢得游戏，恭喜
        //
        private void WonTheGame()
        {
            MessageBox.Show("恭喜,你赢了!真聪明!\n共用了" + count.ToString() + "步\n步骤为" + step, "恭喜!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            for (int i = 0; i < BUTTON_COUNT; i++)
            {
                btn[i].Click -= new EventHandler(btn_Click);
            }

            // 写文件
            FileStream outputfile = null;
            outputfile = new FileStream("step.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outputfile);
            writer.BaseStream.Seek(0, SeekOrigin.End);
            writer.WriteLine(step);
            writer.Flush();
            writer.Close();
        }
    }
}
