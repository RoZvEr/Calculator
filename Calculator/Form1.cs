using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Form1 : Form
    {
        int flag = 0;
        double firstNum = 0;
        double secondNum = 0;
        double ans = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if(answer.Text!="" && length<9)
            {
                answer.Text = answer.Text + "0";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            int length = answer.Text.Length;
            if (length < 9)
            {
                answer.Text = answer.Text + ".";
            }
            btnDot.Enabled = false;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                firstNum = double.Parse(answer.Text);
                flag = 1;
                answer.Text = "";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                firstNum = double.Parse(answer.Text);
                flag = 2;
                answer.Text = "";
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                firstNum = double.Parse(answer.Text);
                flag = 3;
                answer.Text = "";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            ans = 0;
            answer.Text = "";
            flag = 0;

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                firstNum = double.Parse(answer.Text);
                flag = 4;
                answer.Text = "";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(flag==1)
            {
                secondNum = double.Parse(answer.Text);
                ans = firstNum + secondNum;
                answer.Text = Convert.ToString(ans);
            }else if(flag==2)
            {
                secondNum = double.Parse(answer.Text);
                ans = firstNum - secondNum;
                answer.Text = Convert.ToString(ans);
            }
            else if(flag==3)
            {
                secondNum = double.Parse(answer.Text);
                ans = firstNum * secondNum;
                answer.Text = Convert.ToString(ans);
            }
            else if(flag==4)
            {
                secondNum = double.Parse(answer.Text);
                ans = firstNum / secondNum;
                answer.Text = Convert.ToString(ans);
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
            if(ans==0)
            {
                secondNum = 0;
                answer.Text = "";
            }
            else if(secondNum==0)
            {
                flag = 0;
                answer.Text = "";
            }
            else if(flag==0)
            {
                firstNum = 0;
                answer.Text = "";
            }else
            {
                answer.Text = "";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String remove = answer.Text;
            if (remove != "")
            {
                remove = remove.Remove(remove.Length - 1);
            }
            answer.Text = remove;
        }
    }
}
