using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Prelim_Act_2 : Form
    {
        public Prelim_Act_2()
        {
            InitializeComponent();
        }

        int errorcount;
        double adjacent, hypotenuse, opposite, result;
        string msg = "";

        private void txtopp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtopp, "Input numbers only.");
            }
            else
            {
                errorProvider1.SetError(txtopp, "");
            }
        }

        private void txthy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txthy, "Input numbers only.");
            }
            else
            {
                errorProvider1.SetError(txthy, "");
            }
        }

        private void txtadj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtadj, "Input numbers only.");
            }
            else
            {
                errorProvider1.SetError(txtadj, "");
            }
        }

        private void validateAdjacent()
        {
            if (string.IsNullOrEmpty(txtadj.Text))
            {
                errorProvider1.SetError(txtadj, "Input is empty.");
                errorcount++;
            }
            else
            {
                if (double.TryParse(txtadj.Text, out adjacent) &&
                    double.TryParse(txthy.Text, out hypotenuse))
                {
                    if (hypotenuse <= adjacent)
                    {
                        errorProvider1.SetError(txtadj, "Adjacent should be lower than Hypotinuse.");
                        errorcount++;
                    }
                    else
                    {
                        errorProvider1.SetError(txtadj, "");
                    }
                }
            }
        }

        private void validateHypotenuse()
        {
            if (string.IsNullOrEmpty(txthy.Text))
            {
                errorProvider1.SetError(txthy, "Input is empty.");
                errorcount++;
            }
            else
            {
                if (double.TryParse(txthy.Text, out hypotenuse) &&
                double.TryParse(txtadj.Text, out adjacent) &&
                double.TryParse(txtopp.Text, out opposite))
                {
                    if (hypotenuse <= adjacent || hypotenuse <= opposite)
                    {
                        errorProvider1.SetError(txthy, "Hypotenuse side should always be larger than adjacent or opposite side");
                        errorcount++;
                    }
                    else
                    {
                        errorProvider1.SetError(txthy, "");
                    }
                }
            }
        }

        private void validateOpposite()
        {
            if (string.IsNullOrEmpty(txtopp.Text))
            {
                errorProvider1.SetError(txtopp, "Input is empty.");
                errorcount++;
            }
            else
            {
                if (double.TryParse(txtopp.Text, out opposite) &&
                    double.TryParse(txthy.Text, out hypotenuse))
                {
                    if (hypotenuse <= opposite)
                    {
                        errorProvider1.SetError(txtopp, "Opposite should be lower than Hypotinuse.");
                        errorcount++;
                    }
                    else
                    {
                        errorProvider1.SetError(txtopp, "");
                    }
                }
            }
        }

        private void validateOperation()
        {
            if (cmboperation.SelectedIndex < 0)
            {
                errorProvider1.SetError(cmboperation, "Select operation");
            }
            else
            {
                errorProvider1.SetError(cmboperation, "");
            }
        }

        private int errorcount2 = 0;
        private void computeSine()
        {
            validateOpposite();
            validateHypotenuse();
            if (errorcount == 0)
            {
                opposite = double.Parse(txtopp.Text);
                hypotenuse = double.Parse(txthy.Text);
                result = opposite / hypotenuse;
                msg += "Sine: " + result.ToString("F4") + Environment.NewLine;
            }
            else
            {
                errorcount2 += 1;
            }
        }
        private void computeCosine()
        {
            validateAdjacent();
            validateHypotenuse();
            if (errorcount == 0)
            {
                adjacent = double.Parse(txtadj.Text);
                hypotenuse = double.Parse(txthy.Text);
                result = adjacent / hypotenuse;
                msg += "Cosine: " + result.ToString("F4") + Environment.NewLine;
            }
            else
            {
                errorcount2 += 1;
            }
        }

        private void computeTangent()
        {
            validateOpposite();
            validateAdjacent();
            if (errorcount == 0)
            {
                opposite = double.Parse(txtopp.Text);
                adjacent = double.Parse(txtadj.Text);
                result = opposite / adjacent;
                msg += "Tangent: " + result.ToString("F4") + Environment.NewLine;
            }
            else
            {
                errorcount2 += 1;
            }
        }

        private void ClearErrorOutput()
        {
            errorProvider1.Clear();
            msg = "";
        }

        private void btncompute_Click(object sender, EventArgs e)
        {
            ClearErrorOutput();
            errorcount = 0;
            validateOperation();

            if (cmboperation.SelectedIndex == -1)
            {
                return;
            }

            if (errorcount == 0)
            {
                if (cmboperation.SelectedIndex == 0)
                {
                    validateOpposite();
                    validateHypotenuse();
                    if (errorcount == 0)
                    {
                        opposite = double.Parse(txtopp.Text);
                        hypotenuse = double.Parse(txthy.Text);
                        result = opposite / hypotenuse;
                        MessageBox.Show("Result: " + result.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmboperation.SelectedIndex == 1)
                {
                    validateAdjacent();
                    validateHypotenuse();
                    if (errorcount == 0)
                    {
                        adjacent = double.Parse(txtadj.Text);
                        hypotenuse = double.Parse(txthy.Text);
                        result = adjacent / hypotenuse;
                        msg += "Cosine: " + result.ToString("F4") + Environment.NewLine;
                        MessageBox.Show("Result: " + result.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmboperation.SelectedIndex == 2)
                {
                    validateOpposite();
                    validateAdjacent();
                    if (errorcount == 0)
                    {
                        opposite = double.Parse(txtopp.Text);
                        adjacent = double.Parse(txtadj.Text);
                        result = opposite / adjacent;
                        msg += "Tangent: " + result.ToString("F4") + Environment.NewLine;
                        MessageBox.Show("Result: " + result.ToString(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    errorcount2 = 0;
                    computeSine();
                    computeCosine();
                    computeTangent();

                    if (errorcount2 == 0)
                    {
                        MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearErrorOutput();
            txtadj.Clear();
            txthy.Clear();
            txtopp.Clear();
            cmboperation.SelectedIndex = -1;
            txtadj.Focus();
        }
    }
}
