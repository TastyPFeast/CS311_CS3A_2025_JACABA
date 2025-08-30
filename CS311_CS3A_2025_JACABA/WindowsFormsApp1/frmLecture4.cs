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
    public partial class frmLecture4 : Form
    {
        public frmLecture4()
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
            countererror();
            if (errorcount== 0)
            {
                //input
                num1 = double.Parse(txtinput1.Text);
                num2 = double.Parse(txtinput2.Text);
                //process
                if(cbadd.Checked || cbsub.Checked || cbmul.Checked || cbdiv.Checked)
                {
                    string msg = "";
                    if(cbadd.Checked)
                    {
                        result = num1 + num2;
                        msg += "Sum:" + result.ToString() + Environment.NewLine;
                    }
                    if (cbsub.Checked)
                    {
                        result = num1 - num2;
                        msg += "Difference:" + result.ToString() + Environment.NewLine;
                    }
                    if (cbmul.Checked)
                    {
                        result = num1 * num2;
                        msg += "Product:" + result.ToString() + Environment.NewLine;
                    }
                    if (cbdiv.Checked)
                    {
                        result = num1 / num2;
                        msg += "Quotient:" + result.ToString() + Environment.NewLine;
                    }
                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No operation is selected.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtinput1.Clear();
            txtinput2.Clear();
            cbadd.Checked = false;
            cbsub.Checked = false;
            cbmul.Checked = false;
            cbdiv.Checked = false;
            txtinput1.Focus();
        }
    }
}
