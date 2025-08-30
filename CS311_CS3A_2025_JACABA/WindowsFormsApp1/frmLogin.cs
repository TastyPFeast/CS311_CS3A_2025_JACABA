using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS311_CS3A_2025_JACABA;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {

            if (cbshow.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        //declare object that will be a copy of the class1 file
        Class1 login = new Class1("127.0.0.1", "itc127-cs2a-2025-jacaba1", "arvin", "jacaba");
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = login.GetData("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "' AND status = 'ACTIVE'");
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect username or password or account is inactive.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error on BtnLogin_click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnlogin_Click(sender, e);
            }
        }
    }
}
