using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPBox
{
    public partial class IPBox : UserControl
    {
        public IPBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 控制textBox只能输入数字
        /// </summary>
        private void InputNum(KeyPressEventArgs e)
        {
            //只能输入数字和退格键
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
            }
            else
            {
                e.Handled = true;
            }

        }

        /// <summary>
        /// 限定输入数值的范围。
        /// </summary>
        private void InputRange(TextBox tb0)
        {
            if (tb0.Text.Length == 0)
            {
                return;
            }

            //最小值不得小于0,最大值不能大于255
            if (Convert.ToInt16(tb0.Text) < 0 || Convert.ToInt16(tb0.Text) > 255)
            {
                MessageBox.Show(tb0.Text + "不在0-255之间");
                tb0.Text = "255";
            }
        }

        //第一个输入文本框
        private void tbip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNum(e);

            
            //如果按下的符号为“.”或当前文本框多于3个数字，则跳跃到下一个文本框
            if (tbip1.Text.Length >= 2|| e.KeyChar == 46)
            {
                if (tbip1.Text.Length == 0)//当文本框为空时，按下“.”，是不会跳到下个文本框的。
                {
                    tbip1.Focus();
                }

                else
                {
                    tbip2.Focus();
                }
                
            }
        }

        private void tbip1_TextChanged(object sender, EventArgs e)
        {
            InputRange(tbip1);
        }

        //第二个文本框
        private void tbip2_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNum(e);

            if (e.KeyChar == 46 || tbip2.Text.Length >= 2)
            {
                if (tbip2.Text.Length == 0)
                {
                    tbip2.Focus();
                }

                else
                {
                    tbip3.Focus();
                }
            }
            else if (e.KeyChar == 8 && tbip2.Text.Length == 0)//当前文本框无数字时按下退格，则退到上一文本框。
            {
                tbip1.Focus();
            }
        }

        private void tbip2_TextChanged(object sender, EventArgs e)
        {
            InputRange(tbip2);
        }

        private void tbip3_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNum(e);

            if (e.KeyChar == 46 || tbip3.Text.Length >= 2)
            {
                if (tbip3.Text.Length == 0)
                {
                    tbip3.Focus();
                }

                else
                {
                    tbip4.Focus();
                }
            }
            else if (e.KeyChar == 8 && tbip3.Text.Length == 0)//当前文本框无数字时按下退格，则退到上一文本框。
            {
                tbip2.Focus();
            }
        }

        private void tbip3_TextChanged(object sender, EventArgs e)
        {
            InputRange(tbip3);
        }

        private void tbip4_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNum(e);

            if (tbip4.Text.Length >= 2)
            {
                //截取字符
                tbip4.Text = tbip4.Text.Substring(0, 2);
                tbip4.SelectionStart = tbip4.Text.Length;
                tbip4.Focus();
            }
            else if (e.KeyChar == 8 && tbip4.Text.Length == 0)//当前文本框无数字时按下退格，则退到上一文本框。
            {
                tbip3.Focus();
            }
        }

        private void tbip4_TextChanged(object sender, EventArgs e)
        {
            InputRange(tbip4);
        }

        //调用时，初始化
        private void ipBox_Load(object sender, EventArgs e)
        {
            tbip1.Text = "";
            tbip2.Text = "";
            tbip3.Text = "";
            tbip4.Text = "";

        }

        //设置和获得ip地址方法
        public string GetIpAddress()
        {
            string ipValue = string.Empty;
            ipValue = ipValue + tbip1.Text.Trim() + ".";
            ipValue = ipValue + tbip2.Text.Trim() + ".";
            ipValue = ipValue + tbip3.Text.Trim() + ".";
            ipValue = ipValue + tbip4.Text.Trim();

            return ipValue;
        }

        public bool SetIpAddress(string ipValue)
        {
            tbip1.Text = string.Empty;
            tbip2.Text = string.Empty;
            tbip3.Text = string.Empty;
            tbip4.Text = string.Empty;

            //判断ip地址是否合法
            if (ipValue.Length < 7 || ipValue.Length > 15)
            {
                return false;
            }

            int index = 0;
            for (int i = 0; i < 3; i++)
            {
                index = ipValue.IndexOf(".", index + 1);//若IndexOf没有找到符号"."，则返回值为-1
                if (index == -1)
                {
                    return false;
                }
            }

            //解析ip地址
            string[] ipValues = new string[4];
            ipValues = ipValue.Split('.');
            try
            {
                tbip1.Text = Convert.ToInt16(ipValues[0]).ToString();
                tbip2.Text = Convert.ToInt16(ipValues[1]).ToString();
                tbip3.Text = Convert.ToInt16(ipValues[2]).ToString();
                tbip4.Text = Convert.ToInt16(ipValues[3]).ToString();

            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
