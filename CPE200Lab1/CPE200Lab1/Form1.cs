using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        string one = null;
        string two = null;
        bool SetOne = false;
        bool SetTwo = false;
        string calculation=null;
        string answer=null;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if(SetOne == true && SetTwo == false)
            {
                lblDisplay.Text = "";
                SetTwo = true;
            }
            if(SetOne == true && SetTwo == true)
            {
                lblDisplay.Text = "";
                SetTwo = false;
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text += btn.Text;
            }
        }


        private void btnC_Click(object sender, EventArgs e)
        {
           
            one = lblDisplay.Text;
            SetOne = true;
            if ((Button)sender == btnPlus)
            {
                calculation = "+";
            }
            if ((Button)sender == btnMinus)
            {
                calculation = "-";
            }
            if ((Button)sender == btnMultiply)
            {
                calculation = "*";
            }
            if ((Button)sender == btnDivide)
            {
                calculation = "/";
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            two = lblDisplay.Text;
            if (calculation == "+") { 
                answer = (float.Parse(one)+float.Parse(two)).ToString();
            }
            if (calculation == "-")
            {
                answer = (float.Parse(one) - float.Parse(two)).ToString();
            }
            if (calculation == "*")
            {
                answer = (float.Parse(one) * float.Parse(two)).ToString();
            }
            if (calculation == "/")
            {
                answer = (float.Parse(one) / float.Parse(two)).ToString();
            }
            
            lblDisplay.Text = answer;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = (double.Parse(lblDisplay.Text) * -1).ToString();
        }
            

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            SetOne = false;
            SetTwo = false;
            one = null;
            two = null;
            calculation = null;
            answer = null;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
           
                if (calculation == "+" || calculation == "-" || calculation == "*" || calculation == "/")
                {
                    lblDisplay.Text= ((float.Parse(one) * float.Parse(two)) / 100).ToString();
                }
                else
                {
                    lblDisplay.Text = (float.Parse(lblDisplay.Text) / 100).ToString();
                }
            }
        }
    }

