using System;
using System.Drawing;
using System.Windows.Forms;
namespace shaolei
{
    public partial class Frm1 : Form
    {
        #region 变量
        /// <summary>
        /// 旗数
        /// </summary>
        public int qishu;
        public static int ls = 20, hs = 11;
        public int lgs = 30; //列数,行数.
        public int bl = 0; //是否重新布雷
        public int time;
        public int[,] bulei = new int[ls, hs]; //bulei数组的值0代表无雷,1-8代表雷的个数,9代表雷
        public int ceshi = 0;
        public int[,] click = new int[ls, hs]; //10表示要清除既是单击的 11表示右击一次,12表示右击两次 16表示以清除过了
        public int sum = 0;
        private Timer timer1;
        private System.ComponentModel.IContainer components;
        private TextBox gamesource;
        private TextBox labtime;
        private FlowLayoutPanel labdraw;
        private Button button1;
        public int timerEnable = 0; //游戏所处的状态 0是游戏中
        #endregion

        public Frm1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gamesource = new System.Windows.Forms.TextBox();
            this.labtime = new System.Windows.Forms.TextBox();
            this.labdraw = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gamesource
            // 
            this.gamesource.Location = new System.Drawing.Point(0, 0);
            this.gamesource.Name = "gamesource";
            this.gamesource.Size = new System.Drawing.Size(100, 25);
            this.gamesource.TabIndex = 0;
            // 
            // labtime
            // 
            this.labtime.Location = new System.Drawing.Point(153, 12);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(100, 25);
            this.labtime.TabIndex = 1;
            // 
            // labdraw
            // 
            this.labdraw.AutoSize = true;
            this.labdraw.Location = new System.Drawing.Point(28, 67);
            this.labdraw.Name = "labdraw";
            this.labdraw.Size = new System.Drawing.Size(525, 275);
            this.labdraw.TabIndex = 2;
            this.labdraw.Text = "label1";
            this.labdraw.Paint += new System.Windows.Forms.PaintEventHandler(this.labdraw_Paint);
            this.labdraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labdraw_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "重玩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnreplay_Click);
            // 
            // Frm1
            // 
            this.ClientSize = new System.Drawing.Size(603, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labdraw);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.gamesource);
            this.Name = "Frm1";
            this.Load += new System.EventHandler(this.Frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #region 界面事件
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm1_Load(object sender, EventArgs e)
        {
            Qishu(); //输出雷的个数
                     // this.Height = hs * 22 + 20;
                     // this.Width = ls * 22 + 8;
        }

        /// <summary>
        /// 游戏用时计算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time <= 99)
            {
                if (time < 10)
                {
                    labtime.Text = ("00" + time.ToString());
                }
                else
                {
                    labtime.Text = ("0" + time.ToString());
                }
            }
            else
            {
                if (time < 99)
                {
                    labtime.Text = (time.ToString());
                }
                else
                {
                    timer1.Enabled = false;
                    MessageBox.Show("RIME OVER ");
                    time = 0;
                    timerEnable = 1;
                }
            }
        }

        /// <summary>
        /// 初始化游戏界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labdraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics dline = e.Graphics;
            if (bl == 0)
            {
                Blpl();
                Drawscreen(dline);
            }
            else
            {
                Drawscreen(dline);
            }
        }
        ///
        /// //单击时触发的事件
        ///
        ///
        ///
        private void labdraw_MouseClick(object sender, MouseEventArgs e)
        {
            bl = 10;
            int i = 0, j = 0;
            if (timerEnable == 0) //判断游戏是否处于结束状态
            {
                timer1.Enabled = true;
                Graphics dline = labdraw.CreateGraphics(); //将LAB1建立成图形对象
                int mx = 0, my = 0;
                int mx2 = 0, my2 = 0;
                int mx3 = 0, my3 = 0;
                //判断鼠标所点位置
                mx2 = e.X;
                my2 = e.Y;
                for (i = 0; i < ls; i++)
                {
                    for (j = 0; j < hs; j++)
                    {
                        mx = 4 + i * 2 + i * 20;
                        my = 4 + j * 2 + j * 20;
                        //找到单击位置代表的数组
                        if (mx < mx2 && mx + 20 + 4 > mx2 && my < my2 && my2 < my + 20 + 4)
                        {
                            mx3 = i;
                            my3 = j;
                            break;
                        }
                    }
                    if (j < 9)
                    {
                        break;
                    }
                }
                //判断是左击还是右击
                if (e.Button == MouseButtons.Right && click[mx3, my3] != 10 && mx3 >= 0 && my3 >= 0 && click[mx3, my3] != 16)
                {
                    //第2次右击
                    if (click[mx3, my3] == 11 && click[mx3, my3] != 10)
                    {
                        click[mx3, my3] = 12;
                        --qishu;
                    }
                    else
                    {
                        //第1次右击
                        if (click[mx3, my3] != 12 && click[mx3, my3] != 10)
                        {
                            if (qishu > 0) //原来：if (qishu)
                            {
                                click[mx3, my3] = 11;
                                qishu++;
                            }
                        }
                        if (click[mx3, my3] == 12 && click[mx3, my3] != 10)
                        {
                            click[mx3, my3] = 13;
                        }
                    }
                    //右击的绘图事件
                    Rdraw(dline);
                    Qishu();
                }
                else
                {
                    //左击
                    if (click[mx3, my3] != 11 && click[mx3, my3] != 16)
                    {
                        click[mx3, my3] = 15;
                        Color c = Color.FromArgb(224, 224, 224);
                        //清屏 用背景颜色
                        labdraw.CreateGraphics().Clear(c);
                        Panlei(mx3, my3);
                        Drawscreen(dline);
                    }
                    if (bulei[mx3, my3] == 100)
                    {
                        MessageBox.Show("GAME OVER");
                        timer1.Enabled = false;
                        timerEnable = 1;
                    }
                }
                if (sum == lgs)
                {
                    MessageBox.Show("GAME WIN");
                    timer1.Enabled = false;
                    timerEnable = 1;
                }
            }
        }

        ///
        /// 回到游戏开始的界面
        ///
        ///
        ///
        private void btnreplay_Click(object sender, EventArgs e)
        {
            //初始化一切 包括布雷 ,界面, click数组
            Startscr();
        }
        #endregion

        #region 辅助方法
        ///
        /// 标识雷的个数 和可插的旗数
        ///
        public void Qishu()
        {
            if (qishu <= lgs)
            {
                gamesource.Text = "00" + (lgs - qishu).ToString();
            }
            else
            {
                gamesource.Text = "00" + (lgs - qishu).ToString();
            }
        }
        ///
        /// 画方格
        ///
        /// <实例对象>
        /// <要画图的位置>
        /// <要画图的位置>
        /// <画图使用的颜色>
        public void Dline(Graphics dline, int mx1, int my1, Pen mypen)
        {
            dline.DrawLine(mypen, mx1, my1, mx1 + 20, my1);
            dline.DrawLine(mypen, mx1, my1, mx1, my1 + 20);
            dline.DrawLine(new Pen(Color.Black), mx1 + 20, my1, mx1 + 20, my1 + 20);
            dline.DrawLine(new Pen(Color.Black), mx1, my1 + 20, mx1 + 20, my1 + 20);
        }
        ///
        /// 看是否可以向周围移动
        ///
        /// <移动的基本X坐标>
        /// <移动的基本Y坐标>
        public void Panjie(int x, int y)
        {
            Pl(x, y);
            if (y - 1 >= 0)
            {
                Pl(x, y - 1);
                if (x - 1 >= 0)
                {
                    Pl(x - 1, y - 1);
                }
                if (x + 1 > 0)//原来：if (x + 1)
                {
                    Pl(x + 1, y - 1);
                }
            }
            if (y + 1 < hs)
            {
                Pl(x, y + 1);
                if (x - 1 >= 0)
                {
                    Pl(x - 1, y + 1);
                }
                if (x + 1 < ls)
                {
                    Pl(x + 1, y + 1);
                }
            }
            if (x - 1 >= 0)
            {
                Pl(x - 1, y);
            }
            if (x + 1 < ls)
            {
                Pl(x + 1, y);
            }
        }
        ///
        /// 判断是否要清清除
        ///
        /// <要判断的基本X坐标>
        /// <要判断的基本Y坐标>
        public void Pl(int x, int y)
        {
            if (bulei[x, y] == 0 && click[x, y] != 10 && click[x, y] != 11 && click[x, y] != 16)
            {
                click[x, y] = 10;
                Panjie(x, y);
            }
            if (bulei[x, y] > 0 && bulei[x, y] < 9 && click[x, y] != 10 && click[x, y] != 11 && click[x, y] != 16)
            {
                click[x, y] = 10;
            }
        }
        /// <summary>
        /// 初始化数组,布雷,判断周围的雷数
        /// </summary>
        public void Blpl()
        {
            sum = ls * hs;
            qishu = 0;
            int mx, my;
            //初始化数组 9表示雷数
            int mx1, my1;

            for (mx = 0; mx < ls; mx++)
            {
                for (my = 0; my > 0;) //原来：for (my = 0; my;)
                {
                    bulei[mx, my] = 0;
                    click[mx, my] = 0;
                }
            }

            //随机生成雷的个数以及位置
            int sum1 = 0;
            Random r = new Random((int)DateTime.Now.Ticks);
            int leicount = r.Next(1, ls * hs);
            while (sum1 == leicount * 9) //原来 ：while (sum1)
            {
                sum1 = 0;
                mx = r.Next(ls - 1);
                my = r.Next(hs - 1);
                bulei[mx, my] = 9;
                for (mx1 = 0; mx1 < ls; mx1++)
                {
                    for (my1 = 0; my1 < hs; my1++)
                    {
                        sum1 += bulei[mx1, my1];
                    }
                }
            }

            //判断周围雷的个数 —— 设置每一个格子内的值
            for (mx = 0; mx < ls; mx++)
            {
                for (my = 0; my < hs; my++)
                {
                    if (bulei[mx, my] != 9)
                    {
                        if (mx - 1 >= 0)
                        {
                            //左边
                            if (bulei[mx - 1, my] == 9)
                            {
                                bulei[mx, my]++;
                            }
                            //左上角
                            if (my - 1 >= 0 && bulei[mx - 1, my - 1] == 9)
                            {
                                bulei[mx, my]++;
                            }
                            //左下角
                            if (my + 1 < hs && bulei[mx - 1, my + 1] == 9)
                            {
                                bulei[mx, my]++;
                            }
                        }
                        if (mx + 1 < ls) //原来：if (mx + 1)
                                         // if (Convert.ToBoolean(mx + 1))
                        {
                            //右边
                            if (bulei[mx + 1, my] == 9)
                            {
                                bulei[mx, my]++;
                            }
                            //右上角
                            if (my - 1 >= 0 && bulei[mx + 1, my - 1] == 9)
                            {
                                bulei[mx, my]++;
                            }
                            //右下角
                            if (my + 1 < hs && bulei[mx + 1, my + 1] == 9)
                            {
                                bulei[mx, my]++;
                            }
                        }
                        //上面
                        if (my - 1 >= 0 && bulei[mx, my - 1] == 9)
                        {
                            bulei[mx, my]++;
                        }
                        //下面
                        if (my + 1 < hs) //原来：if (my + 1)
                        {
                            bulei[mx, my]++;
                        }
                    }
                }
            }
        }
        ///
        /// 右击的重绘
        ///
        /// >
        public void Rdraw(Graphics dline)
        {
            string text;
            int mx, my;
            int mx1, my1;
            for (mx = 0; mx < ls; mx++)
            {
                for (my = 0; my < hs; my++)
                {
                    mx1 = mx * 2 + mx * 20 + 4;
                    my1 = my * 2 + my * 20 + 4;
                    if (click[mx, my] == 11)
                    {
                        //第一次右击画旗
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1 + 20, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1, my1 + 20, mx1 + 20, my1 + 20);
                        dline.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), mx1 + 1, my1 + 1, 18, 18);
                        text = "P";
                        dline.DrawString(text, new Font("宋体", 15), new SolidBrush(Color.Red), mx1 + 2, my1 + 2);
                    }
                    if (click[mx, my] == 12)
                    {
                        //第二次右击画问号
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1 + 20, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1, my1 + 20, mx1 + 20, my1 + 20);
                        dline.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), mx1 + 1, my1 + 1, 18, 18);
                        text = "?";
                        dline.DrawString(text, new Font("宋体", 15), new SolidBrush(Color.Black), mx1 + 2, my1 + 2);
                    }
                    if (click[mx, my] == 13)
                    {
                        //第三次右击 恢复原样
                        click[mx, my] = 2;
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.White), mx1, my1, mx1, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1 + 20, my1, mx1 + 20, my1 + 20);
                        dline.DrawLine(new Pen(Color.Black), mx1, my1 + 20, mx1 + 20, my1 + 20);
                        dline.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), mx1 + 1, my1 + 1, 18, 18);
                    }
                }
            }
        }
        ///
        /// 初始化屏幕 (包还所有的)
        ///
        public void Startscr()
        {
            Graphics dline = labdraw.CreateGraphics();
            time = 0;
            Blpl();
            timer1.Enabled = false;
            Color c = Color.FromArgb(224, 224, 224);
            labdraw.CreateGraphics().Clear(c);
            Drawscreen(dline);
            timerEnable = 0;
            labtime.Text = ("000");
        }
        ///
        /// 画界面
        ///
        /// >
        public void Drawscreen(Graphics dline)
        {
            sum = 0; //得到没清楚的格子数
            int mx, my;
            int mx1 = 0, my1 = 0; //得到要画图的坐标
            string text;
            for (mx = 0; mx < ls; mx++)
            {
                for (my = 0; my < hs; my++)
                {
                    //画图地位置 mx,my分别是屏幕x,y轴
                    mx1 = mx * 2 + mx * 20 + 4;
                    my1 = my * 2 + my * 20 + 4;
                    if (click[mx, my] != 10 && click[mx, my] != 12 && click[mx, my] != 16 && click[mx, my] != 15)
                    {
                        //下面用于画立体形矩形;
                        sum++;
                        Pen mypen = new Pen(Color.Gray);
                        Dline(dline, mx1, my1, mypen);
                        dline.FillRectangle(new SolidBrush(Color.FromArgb(224, 224, 224)), mx1 + 1, my1 + 1, 18, 18);
                    }
                    if ((click[mx, my] == 10 || click[mx, my] == 16))
                    {
                        click[mx, my] = 16; //清除的格子
                                            //提示周围的雷数
                        if (bulei[mx, my] <= 8 && bulei[mx, my] > 0)
                        {
                            text = bulei[mx, my].ToString();
                            dline.DrawString(text, new Font("宋体", 15), new SolidBrush(Color.Black), mx1 + 2, my1 + 2);
                        }
                        //显示雷
                        if ((bulei[mx, my] == 9 || bulei[mx, my] == 100))
                        {
                            text = "*";
                            dline.DrawString(text, new Font("宋体", 15), new SolidBrush(Color.Black), mx1 + 2, my1 + 2);
                            if (bulei[mx, my] == 100)
                            {
                                //被单击的雷上画上叉号
                                dline.DrawLine(new Pen(Color.Red), mx1, my1, mx1 + 20, my1 + 20);
                                dline.DrawLine(new Pen(Color.Red), mx1, my1 + 20, mx1 + 20, my1);
                            }
                        }
                    }
                }
                //用于画旗 和问号
                Rdraw(dline);
            }
        }
        ///
        /// 当为雷时的算法
        ///
        /// >
        /// >
        public void Panlei(int x, int y)
        {
            if (bulei[x, y] != 0)
            {
                if (bulei[x, y] == 9)
                {
                    timer1.Enabled = false; //使计时器停止
                    timerEnable = 1; //使游戏出游结束状态
                    bulei[x, y] = 100;
                    int i, j;
                    for (i = 0; i < ls; i++)
                    {
                        for (j = 0; j < hs; j++)
                        {
                            if (bulei[i, j] == 9 || bulei[i, j] == 100)
                            {
                                click[i, j] = 10; //显示所有的雷
                            }
                        }
                    }
                }
                if (bulei[x, y] > 0 && bulei[x, y] < 9)
                {
                    click[x, y] = 10;
                }
            }
            else
            {
                Panjie(x, y);
            }
        }
        #endregion

    }
}