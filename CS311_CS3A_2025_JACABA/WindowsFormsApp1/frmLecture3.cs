using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmLecture3 : Form
    {
        public frmLecture3()
        {
            InitializeComponent();
        }

        private void txtinput1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtinput2_KeyPress(object sender, KeyPressEventArgs e)
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

        private int errorcount;

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

        private void validateOperation()
        {
            if(cmboperation.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmboperation, "Select operation");
            }
            else
            {
                errorProvider1.SetError(cmboperation, "");
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

        private double num1, num2, result;

        private void btncompute_Click(object sender, EventArgs e)
        {
            validateInput1();
            validateInput2();
            validateOperation();
            countererror();
            if (errorcount== 0)
            {
                //input
                num1 = double.Parse(txtinput1.Text);
                num2 = double.Parse(txtinput2.Text);
                //process
                if (cmboperation.SelectedIndex== 0)
                {
                    result = num1 + num2;
                }
                else if (cmboperation.SelectedIndex== 1)
                {
                    result = num1 - num2;
                }
                else if (cmboperation.SelectedIndex == 2)
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }
                //output
                MessageBox.Show("Result: " + result.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtinput1.Clear();
            txtinput2.Clear();
            cmboperation.SelectedIndex = -1;
            txtinput1.Focus();
        }
    }
}
