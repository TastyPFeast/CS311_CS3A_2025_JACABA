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
    public partial class Act1 : Form
    {
        public Act1()
        {
            InitializeComponent();
        }

        private int sideA, sideB, sideC, height, errorcount, perimeter;

        private void validateInputA()
        {
            if (string.IsNullOrEmpty(txtsideA.Text))
            {
                errorProvider1.SetError(txtsideA, "Input is empty.");
                errorcount++;
            }
            else
            {
                errorProvider1.SetError(txtsideA, "");
            }
        }

        private void validateInputB()
        {
            if (string.IsNullOrEmpty(txtsideB.Text))
            {
                errorProvider1.SetError(txtsideB, "Input is empty.");
                errorcount++;
            }
            else
            {
                errorProvider1.SetError(txtsideB, "");
            }
        }

        private void validateInputC()
        {
            if (string.IsNullOrEmpty(txtsideC.Text))
            {
                errorProvider1.SetError(txtsideC, "Input is empty.");
                errorcount++;
            }
            else
            {
                if(int.TryParse(txtsideA.Text, out sideA) &&
                   int.TryParse(txtsideB.Text, out sideB) &&
                   int.TryParse(txtsideC.Text, out sideC))
                {
                    if (sideC <= sideA || sideC <= sideB)
                    {
                        errorProvider1.SetError(txtsideC, "Side C should be larger than Side A or Side B.");
                        errorcount++;
                    }
                    else
                    {
                        errorProvider1.SetError(txtsideC, "");
                    }
                }
            }

            if (errorcount == 0)
            {
                errorProvider1.SetError(txtsideC, "");
            }
        }

        private void validateInputheight()
        {
            if (string.IsNullOrEmpty(txtheight.Text))
            {
                errorProvider1.SetError(txtheight, "Input is empty.");
                errorcount++;
            }
            else
            {
                errorProvider1.SetError(txtheight, "");
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

        private void txtsideA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsideA, "Input a number only.");
                txtsideA.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsideA, "");
            }
        }

        private void txtsideB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsideB, "Input a number only.");
                txtsideB.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsideB, "");
            }
        }

        private void txtsideC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtsideC, "Input a number only.");
                txtsideC.Focus();
            }
            else
            {
                errorProvider1.SetError(txtsideC, "");
            }
        }

        private void txtheight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtheight, "Input a number only.");
                txtheight.Focus();
            }
            else
            {
                errorProvider1.SetError(txtheight, "");
            }
        }

        private void clearErrorOutput()
        {
            errorcount = 0;
            errorProvider1.Clear();
            txtareares.Clear();
            txtperimeterres.Clear();
        }
        
        private void ComputeArea()
        {
            validateInputB();
            validateInputheight();
            countererror();

            if (errorcount == 0)
            {
                //input
                sideB = int.Parse(txtsideB.Text);
                height = int.Parse(txtheight.Text);
                //process
                float area = (float)(sideB * height) / 2;
                //output
                txtareares.Text = area.ToString("0.##");
            }
        }

        private void ComputePerimeter()
        {
            validateInputA();
            validateInputB();
            validateInputC();
            countererror();

            if (errorcount == 0)
            {
                //input
                sideA = int.Parse(txtsideA.Text);
                sideB = int.Parse(txtsideB.Text);
                sideC = int.Parse(txtsideC.Text);
                //process
                perimeter = sideA + sideB + sideC;
                //output
                txtperimeterres.Text = perimeter.ToString();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            clearErrorOutput();
            ComputeArea();
        }

        private void btnPerimeter_Click(object sender, EventArgs e)
        {
            clearErrorOutput();
            ComputePerimeter();
        }

        private void btnComputeall_Click(object sender, EventArgs e)
        {
            clearErrorOutput();
            ComputeArea();
            ComputePerimeter();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsideA.Clear();
            txtsideB.Clear();
            txtsideC.Clear();
            txtheight.Clear();
            txtareares.Clear();
            txtperimeterres.Clear();
            txtsideA.Focus();
            errorProvider1.Clear();
        }



    }
}
