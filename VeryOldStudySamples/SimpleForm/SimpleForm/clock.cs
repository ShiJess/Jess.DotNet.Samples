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
    public partial class ClockFrom : Form
    {
        public ClockFrom()
        {
            InitializeComponent();
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            if(sender==Clock)//可以省去此判断
            {
                lbTime.Text = GetTime();
            }
        }
        public string GetTime()
        {
            string TimeInString = "";
            int hour = System.DateTime.Now.Hour;
            int min = System.DateTime.Now.Minute;
            int sec = System.DateTime.Now.Second;

            //若获取时间值为一位数，前面加0
            TimeInString = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            TimeInString += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            TimeInString += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());
            //若如下写，一位数时，只显示一位数。
            //TimeInString = hour.ToString() + ":" + min.ToString() + ":" + sec.ToString();
            return TimeInString;
        }
    }
}
