using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLecture1 : Form
    {
        public frmLecture1()
        {
            InitializeComponent();
        }

        private int num1, num2, result, errorcount;

        //Digit validation for txtinput1 and txtinput2
        private void validateInput1()
        {
            if (string.IsNullOrEmpty(txtinput1.Text))
            {
                errorProvider1.SetError(txtinput1, "Input is empty.");
                errorcount++;
            }
            else
            {
                errorProvider1.SetError(txtinput1, "");
            }
        }

        private void validateInput2()
        {
            if (string.IsNullOrEmpty(txtinput2.Text))
            {
                errorProvider1.SetError(txtinput2, "Input is empty.");
                errorcount++;
            }
            else
            {
                errorProvider1.SetError(txtinput2, "");
            }
        }

        private void countererror()
        {
            errorcount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (!String.IsNullOrEmpty(errorProvider1.GetError(c)))
                {
                    errorcount++;
                }
            }
        }

        private void txtinput1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtinput1, "Input a number only.");
                txtinput1.Focus();
            }
            else
            {
                errorProvider1.SetError(txtinput1, "");
            }
        }

        private void txtinput2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtinput2, "Input a number only.");
                txtinput2.Focus();
            }
            else
            {
                errorProvider1.SetError(txtinput2, "");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            validateInput1();
            validateInput2();
            countererror();

            if (errorcount == 0)
            {
                //input
                num1 = int.Parse(txtinput1.Text);
                num2 = int.Parse(txtinput2.Text);
                //process
                result = num1 * num2;
                //output
                txtresult.Text = result.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            validateInput1();
            validateInput2();
            countererror();

            if (errorcount == 0)
            {
                //input
                num1 = int.Parse(txtinput1.Text);
                num2 = int.Parse(txtinput2.Text);
                //process
                result = num1 / num2;
                //output
                txtresult.Text = result.ToString();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            validateInput1();
            validateInput2();
            countererror();

            if(errorcount == 0)
            {
                //input
                num1 = int.Parse(txtinput1.Text);
                num2 = int.Parse(txtinput2.Text);
                //process
                result = num1 + num2;
                //output
                txtresult.Text = result.ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            validateInput1();
            validateInput2();
            countererror();

            if (errorcount == 0)
            {
                //input
                num1 = int.Parse(txtinput1.Text);
                num2 = int.Parse(txtinput2.Text);
                //process
                result = num1 - num2;
                //output
                txtresult.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtinput1.Clear();
            txtinput2.Clear();
            txtresult.Clear();
            txtinput1.Focus();
            errorProvider1.Clear();
        }

    }
}
