using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2WinForm
{
    public partial class Form1 : Form
    {
        double firstNum;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnNum0_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text != "")
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 0;
            }
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "1";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 1;
                LblSaveNum.Text = LblSaveNum.Text + 1;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "1";
            }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "2";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 2;
                LblSaveNum.Text = LblSaveNum.Text + 2;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "2";
            }
        }

        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "3";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 3;
                LblSaveNum.Text = LblSaveNum.Text + 3;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "3";
            }
        }

        private void BtnNum4_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "4";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 4;
                LblSaveNum.Text = LblSaveNum.Text + 4;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "4";
            }
        }

        private void BtnNum5_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "5";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 5;
                LblSaveNum.Text = LblSaveNum.Text + 5;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "5";
            }
        }

        private void BtnNum6_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "6";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 6;
                LblSaveNum.Text = LblSaveNum.Text + 6;
            }

            if(LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "6";                
            }
        }

        private void BtnNum7_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "7";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 7;
                LblSaveNum.Text = LblSaveNum.Text + 7;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "7";
            }
        }

        private void BtnNum8_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "8";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 8;
                LblSaveNum.Text = LblSaveNum.Text + 8;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "8";
            }
        }

        private void BtnNum9_Click(object sender, EventArgs e)
        {
            if (TxtBoxNumber.Text == "0" && TxtBoxNumber.Text != null)
            {
                TxtBoxNumber.Text = "9";
            }
            else
            {
                TxtBoxNumber.Text = TxtBoxNumber.Text + 9;
                LblSaveNum.Text = LblSaveNum.Text + 9;
            }

            if (LblSaveNum.Text == "")
            {
                LblSaveNum.Text = "9";
            }
        }
        
        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(TxtBoxNumber.Text);
            TxtBoxNumber.Text = "0";
            Operation = "*";
            LblSaveNum.Text += " ";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(TxtBoxNumber.Text);
            TxtBoxNumber.Text = "0";
            Operation = "/";
            LblSaveNum.Text += " / ";
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(TxtBoxNumber.Text);
            TxtBoxNumber.Text = "0";
            Operation = "-";
            LblSaveNum.Text += " - ";
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(TxtBoxNumber.Text);
            TxtBoxNumber.Text = "0";
            Operation = "+";
            LblSaveNum.Text += " + ";
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {

        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            LblSaveNum.Text = "";
            TxtBoxNumber.Text = "";
            firstNum = 0;
        }

        private void BtnPlusMin_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            double secondnumber = Convert.ToDouble(TxtBoxNumber.Text);
            double result = 0;
            
            if (Operation == "*")
            {
                result = firstNum * secondnumber;
                TxtBoxNumber.Text = Convert.ToString(result);
                firstNum = result;
            }
            else if (Operation == "/")
            {
                if (secondnumber == 0)
                {
                    MessageBox.Show("You can't divide by 0");
                    TxtBoxNumber.Text = "0";
                }
                else
                {
                    result = firstNum / secondnumber;
                    TxtBoxNumber.Text = Convert.ToString(result);
                    firstNum = result;
                }
            }
            else if (Operation == "-")
            {
                result = firstNum - secondnumber;
                TxtBoxNumber.Text = Convert.ToString(result);
                firstNum = result;
            }
            else if (Operation == "+")
            {
                result = firstNum + secondnumber;
                TxtBoxNumber.Text = Convert.ToString(result);
                firstNum = result;
            }

            LblSaveNum.Text = result.ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            LblSaveNum.TextAlign = ContentAlignment.MiddleRight;
            
        }
    }
}
