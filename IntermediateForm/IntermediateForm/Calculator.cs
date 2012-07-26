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
    public partial class Calculator : Form
    {
        private int opMain = 0;
        private double mainNum1 = 0;
        private double mainNum2 = 0;
        private bool isSecond = false;
        private bool isDone = false;
        private bool isDecimal = false;


        public Calculator()
        {
            InitializeComponent();
        }


        public void setText(String textset)
        {
            if (textset.Equals("clear")) //If the user hits the clear button
            {
                txtResult.Text = ""; //Clear the text and reset the boolean variables.
                isDone = false;
                isSecond = false;
                isDecimal = false;

            }
            else
            {
                if (isSecond) //Determine if the number being entered is the begining of the second number. If it is:
                {
                    txtResult.Text = textset; //Start the text over and set the first # to what the user enters
                    isSecond = false; //So Calculator knows to continue the # rather than making a new one.
                    isDecimal = false;
                }
                else
                {
                    if (isDone) //isDone lets the program know that the user just hit "=" and if they press another # to start a new number.
                    {
                        txtResult.Text = textset;
                        isDone = false; //Set isDone to false so that the number just started is added on to and a new # is not started.

                    }
                    else
                        txtResult.Text += textset; //Simply add on to the existing #.

                }
            }
            btnEquals.Select(); //Set the focus back to the "=" button.
        }

        public void Calc(double num1, double num2, int op)
        {
            double answer = 0;//Initialize answer to 0;
            switch (op)		//Determine which operation to perform depending on the value of "op"
            {
                case 1:
                    answer = num1 + num2;
                    break;
                case 2:
                    answer = num1 - num2;
                    break;
                case 3:
                    answer = num1 * num2;
                    break;
                case 4:
                    answer = num1 / num2;
                    break;
            }
            setText(answer.ToString()); //Show the answer in the textbox;
        }

        private void doEquals()
        {
            mainNum2 = double.Parse(txtResult.Text);	//Set the value of the second number
            setText("clear"); //Clear the textbox
            Calc(mainNum1, mainNum2, opMain); //Call the Calc method
            isDone = true; //Set isDone to true so that if another # is pressed, the program will begin a new number
        }

        private void changeSign()
        {
            double storNum; //Variable to store value of number
            if (txtResult.Text.Length > 0) //If there is a number...
            {
                storNum = double.Parse(txtResult.Text); //Store its value
                storNum *= -1; //multiply by negative 1
                txtResult.Text = storNum.ToString(); //put it in the textbox.
            }
            btnEquals.Select(); //Set focus to "=" button
        }

        private void setOperator(int operation)
        {
            if (txtResult.Text.Length > 0)//Make sure that the user entered a number
            {
                opMain = operation; //Store the operation
                mainNum1 = double.Parse(txtResult.Text); //Store the value of the first number
                isSecond = true; //Let the program know to begin the second number
                isDone = false; //If a operator button is pressed before a new number, let the program know to start a new number.
                btnEquals.Select(); //Set the focus to the equals button.
            }
        }

        private void setDecimal()
        {
            if (!isDecimal)//Check for existing decimal
            {
                setText("."); //Add decimal
                isDecimal = true; //Let program know decimal has been added
            }
            btnEquals.Select(); //Set focus to "=" button
        }

        public void filterKeys(int keyCode)
        {
            switch (keyCode)
            {
                case 96:
                    setText("0");
                    break;
                case 97:
                    setText("1");
                    break;
                case 98:
                    setText("2");
                    break;
                case 99:
                    setText("3");
                    break;
                case 100:
                    setText("4");
                    break;
                case 101:
                    setText("5");
                    break;
                case 102:
                    setText("6");
                    break;
                case 103:
                    setText("7");
                    break;
                case 104:
                    setText("8");
                    break;
                case 105:
                    setText("9");
                    break;
                case 67:
                    setText("clear");
                    break;
                case 107:
                    setOperator(1);
                    break;
                case 109:
                    setOperator(2);
                    break;
                case 106:
                    setOperator(3);
                    break;
                case 111:
                    setOperator(4);
                    break;
                case 110:
                    setDecimal();
                    break;
            }
        }









        private void Calculator1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            filterKeys(e.KeyValue);
        }

        private void btn1_Click(object sender, System.EventArgs e)
        {
            setText("1");
        }

        private void btn2_Click(object sender, System.EventArgs e)
        {
            setText("2");
        }

        private void btn3_Click(object sender, System.EventArgs e)
        {
            setText("3");
        }

        private void btn4_Click(object sender, System.EventArgs e)
        {
            setText("4");
        }

        private void btn5_Click(object sender, System.EventArgs e)
        {
            setText("5");
        }

        private void btn6_Click(object sender, System.EventArgs e)
        {
            setText("6");
        }

        private void btn7_Click(object sender, System.EventArgs e)
        {
            setText("7");
        }

        private void btn8_Click(object sender, System.EventArgs e)
        {
            setText("8");
        }

        private void btn9_Click(object sender, System.EventArgs e)
        {
            setText("9");
        }

        private void btn0_Click(object sender, System.EventArgs e)
        {
            setText("0");
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            setOperator(1);
        }

        private void btnSubtract_Click(object sender, System.EventArgs e)
        {
            setOperator(2);
        }

        private void btnMultiply_Click(object sender, System.EventArgs e)
        {
            setOperator(3);
        }

        private void btnDivide_Click(object sender, System.EventArgs e)
        {
            setOperator(4);
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            isSecond = false;
            setText("clear");
        }

        private void btnNegative_Click(object sender, System.EventArgs e)
        {
            changeSign();
        }

        private void btnDecimal_Click(object sender, System.EventArgs e)
        {
            setDecimal();
        }

        private void btnEquals_Click(object sender, System.EventArgs e)
        {
            doEquals();
        }



    }
}
