using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.cs
{
    public partial class Form1 : Form
    {
        private float fnum, snum; //float number assign
        private float result; 
        private char opt;
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "0")
                txtOne.Text = "1";
            else
            {
                if (flag)
                {
                    txtOne.Text = "1";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "1";
                }
            }

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "0")
                txtOne.Text = "2";
            else
            {
                if (flag)
                {
                    txtOne.Text = "2";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "2";
                }
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "0")
                txtOne.Text = "3";
            else
            {
                if (flag)
                {
                    txtOne.Text = "3";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "3";
                }
            }
        }


        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtOne.Text == "0")
                txtOne.Text = "4";
            else
            {
                if (flag)
                {
                    txtOne.Text = "4";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "4";
                }
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            
            if (txtOne.Text == "0")
                txtOne.Text = "5";
            else
            {
                if (flag)
                {
                    txtOne.Text = "5";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "5";
                }
            }

        }

        private void btnSix_Click(object sender, EventArgs e)
        {
           
            if (txtOne.Text == "0")
                txtOne.Text = "6";
            else
            {
                if (flag)
                {
                    txtOne.Text = "6";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "6";
                }
            }

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
          
            if (txtOne.Text == "0")
                txtOne.Text = "7";
            else
            {
                if (flag)
                {
                    txtOne.Text = "7";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "7";
                }
            }

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
           
            if (txtOne.Text == "0")
                txtOne.Text = "8";
            else
            {
                if (flag)
                {
                    txtOne.Text = "8";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "8";
                }
            }

        }

        private void btnNine_Click(object sender, EventArgs e)
        {
          
            if (txtOne.Text == "0")
                txtOne.Text = "9";
            else
            {
                if (flag)
                {
                    txtOne.Text = "9";
                    flag = false;
                }
                else
                {
                    txtOne.Text += "9";
                }
            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
          
            if (txtOne.Text == "0")
                txtOne.Text = "0";
            
                
             else
                {
                    txtOne.Text += "0";
                }
            }

        private void btnSum_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtOne.Text);
            opt = '+';
            label1.Text = fnum + "+";
            flag = true;

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtOne.Text);
            opt = '-';
            label1.Text = fnum + "-";
            flag = true;
        }


        private void btnMul_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtOne.Text);
            opt = '*';
            label1.Text = fnum + "*";
            flag = true;

        }
        

        private void btnDiv_Click(object sender, EventArgs e)
        {
            fnum = Convert.ToInt32(txtOne.Text);
            opt = '/';
            label1.Text = fnum + "/";
            flag = true;
        }

         private void btnMod_Click(object sender, EventArgs e)
        {

            fnum = Convert.ToInt32(txtOne.Text);
            opt = '%';
            label1.Text = fnum + "%";
            flag = true;

        }

         private void btnsqu_Click(object sender, EventArgs e)
         {
             fnum = Convert.ToInt32(txtOne.Text);
             opt = '^';
             label1.Text = fnum + "^";
             flag = true;

         }
        

        private void btnEqual_Click(object sender, EventArgs e)
        {
            snum = Convert.ToInt32(txtOne.Text);
            if (opt == '+')
            {
                result = fnum + snum;
                label1.Text = fnum + "+" + snum + "=";
                txtOne.Text = result + "";
            }
            else if (opt == '-')
            {
                result = fnum - snum;
                label1.Text = fnum + "-" + snum + "=";
                txtOne.Text = result + "";
            }
            else if ( opt == '*')
            {
                result = fnum * snum;
                label1.Text = fnum + "*" + snum + "=";
                txtOne.Text = result + "";
            }
            else if (opt == '/')
            {
                result = fnum / snum;
                label1.Text = fnum + "/" + snum + "=";
                txtOne.Text = result + "";
            }
            else if (opt == '%')
            {
                result = fnum % snum;
                label1.Text = fnum + "%" + snum + "=";
                txtOne.Text = result + "";
            }
            else if (opt == '^')
            {
                result = fnum * fnum;
                label1.Text = fnum + "^" + fnum + "=";
                txtOne.Text = result + "";
            }  
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            txtOne.Text = "";
        }

        

             
        
    }
}
