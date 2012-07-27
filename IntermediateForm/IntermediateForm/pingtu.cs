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
    public partial class pingtu : Form
    {
        int flag;
        private int count;
        private int[] numbers = new int[16];

        public pingtu()
        {
            InitializeComponent();
        }

        private void t1_KeyDown(object sender, KeyEventArgs e)
        {
            if (flag == 0)
            {
                string keyId = e.KeyCode.ToString();
                switch (keyId)
                {
                    case "Right": LeftPress();
                        break;
                    case "Left": RightPress();
                        break;
                    case "Down": UpPress();
                        break;
                    case "Up": DownPress();
                        break;
                }
            }
        }

        public void RightPress()
        {
            int chk;
            int loc;
            int swap;
            loc = locator();
            if (((loc + 1) % 4) == 0)
                return;
            swap = numbers[loc + 1];
            numbers[loc + 1] = -1;
            numbers[loc] = swap;
            MakeVisible();
            assign();
            chk = CheckForCompletion();
            lbl3.Text = count.ToString();
            if (chk == 0)
            {
                count++;
                lbl3.Text = count.ToString();
            }
            if (chk == 1)
            {
                flag = 1;
                lbl1.Visible = true;
            }
        }
        public void LeftPress()
        {
            int chk;
            int loc;
            int swap;
            loc = locator();
            if ((loc % 4) == 0)
                return;
            swap = numbers[loc - 1];
            numbers[loc - 1] = -1;
            numbers[loc] = swap;
            MakeVisible();
            assign();
            chk = CheckForCompletion();
            lbl3.Text = count.ToString();
            if (chk == 0)
            {
                count++;
                lbl3.Text = count.ToString();
            }
            if (chk == 1)
            {
                flag = 1;
                lbl1.Visible = true;
            }

        }
        public void UpPress()
        {
            int chk;
            int loc;
            int swap;
            loc = locator();
            if (loc <= 3)
                return;
            swap = numbers[loc - 4];
            numbers[loc - 4] = -1;
            numbers[loc] = swap;
            MakeVisible();
            assign();
            chk = CheckForCompletion();
            lbl3.Text = count.ToString();
            if (chk == 0)
            {
                count++;
                lbl3.Text = count.ToString();
            }
            if (chk == 1)
            {
                flag = 1;
                lbl1.Visible = true;
            }

        }
        public void DownPress()
        {
            int chk;
            int loc;
            int swap;
            loc = locator();
            if (loc > 11)
                return;
            swap = numbers[loc + 4];
            numbers[loc + 4] = -1;
            numbers[loc] = swap;
            MakeVisible();
            assign();
            chk = CheckForCompletion();
            lbl3.Text = count.ToString();
            if (chk == 0)
            {
                count++;
                lbl3.Text = count.ToString();
            }
            if (chk == 1)
            {
                flag = 1;
                lbl1.Visible = true;
            }

        }

        private int locator()
        {
            int i;
            for (i = 0; i <= 15; i++)
            {
                if (numbers[i] == -1)
                    break;
                else continue;
            }
            return i;
        }

        private void assign()
        {
            if (numbers[0] != -1)
                b1.Text = numbers[0].ToString();
            else
            {
                b1.Text = "*";
                b1.Visible = false;
            }
            if (numbers[1] != -1)
                b2.Text = numbers[1].ToString();
            else
            {
                b2.Text = "*";
                b2.Visible = false;
            }
            if (numbers[2] != -1)
                b3.Text = numbers[2].ToString();
            else
            {
                b3.Text = "*";
                b3.Visible = false;
            }
            if (numbers[3] != -1)
                b4.Text = numbers[3].ToString();
            else
            {
                b4.Text = "*";
                b4.Visible = false;
            }
            if (numbers[4] != -1)
                b5.Text = numbers[4].ToString();
            else
            {
                b5.Text = "*";
                b5.Visible = false;
            }
            if (numbers[5] != -1)
                b6.Text = numbers[5].ToString();
            else
            {
                b6.Text = "*";
                b6.Visible = false;
            }
            if (numbers[6] != -1)
                b7.Text = numbers[6].ToString();
            else
            {
                b7.Text = "*";
                b7.Visible = false;
            }
            if (numbers[7] != -1)
                b8.Text = numbers[7].ToString();
            else
            {
                b8.Text = "*";
                b8.Visible = false;
            }
            if (numbers[8] != -1)
                b9.Text = numbers[8].ToString();
            else
            {
                b9.Text = "*";
                b9.Visible = false;
            }
            if (numbers[9] != -1)
                b10.Text = numbers[9].ToString();
            else
            {
                b10.Text = "*";
                b10.Visible = false;
            }
            if (numbers[10] != -1)
                b11.Text = numbers[10].ToString();
            else
            {
                b11.Text = "*";
                b11.Visible = false;
            }
            if (numbers[11] != -1)
                b12.Text = numbers[11].ToString();
            else
            {
                b12.Text = "*";
                b12.Visible = false;
            }
            if (numbers[12] != -1)
                b13.Text = numbers[12].ToString();
            else
            {
                b13.Text = "*";
                b13.Visible = false;
            }
            if (numbers[13] != -1)
                b14.Text = numbers[13].ToString();
            else
            {
                b14.Text = "*";
                b14.Visible = false;
            }
            if (numbers[14] != -1)
                b15.Text = numbers[14].ToString();
            else
            {
                b15.Text = "*";
                b15.Visible = false;
            }
            if (numbers[15] != -1)
                b16.Text = numbers[15].ToString();
            else
            {
                b16.Text = "*";
                b16.Visible = false;
            }


        }


        private int CheckForCompletion()
        {
            int j;

            for (int i = 0; i <= 15; i++)
            {
                if (numbers[i] == -1)
                    numbers[i] = 16;
            }
            for (j = 0; j <= 14; j++)
            {
                if (numbers[j] > numbers[j + 1])
                    break;
            }
            if (j == 15)
                return 1;
            else
            {
                for (int i = 0; i <= 15; i++)
                {
                    if (numbers[i] == 16)
                        numbers[i] = -1;
                }
                return 0;
            }

        }

        private void MakeVisible()
        {
            b1.Visible = true;
            b2.Visible = true;
            b3.Visible = true;
            b4.Visible = true;
            b5.Visible = true;
            b6.Visible = true;
            b7.Visible = true;
            b8.Visible = true;
            b9.Visible = true;
            b10.Visible = true;
            b11.Visible = true;
            b12.Visible = true;
            b13.Visible = true;
            b14.Visible = true;
            b15.Visible = true;
            b16.Visible = true;
        }




    }
}
