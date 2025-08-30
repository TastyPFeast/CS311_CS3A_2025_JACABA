namespace WindowsFormsApp1
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.cbshow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(87, 29);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(263, 20);
            this.txtusername.TabIndex = 2;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Thistle;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Location = new System.Drawing.Point(126, 102);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(91, 38);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "&Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(87, 55);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(263, 20);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpassword_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Thistle;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.Location = new System.Drawing.Point(236, 102);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(91, 38);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cbshow
            // 
            this.cbshow.AutoSize = true;
            this.cbshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbshow.Location = new System.Drawing.Point(248, 81);
            this.cbshow.Name = "cbshow";
            this.cbshow.Size = new System.Drawing.Size(102, 17);
            this.cbshow.TabIndex = 7;
            this.cbshow.Text = "&Show Password";
            this.cbshow.UseVisualStyleBackColor = true;
            this.cbshow.CheckedChanged += new System.EventHandler(this.cbshow_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(408, 160);
            this.Controls.Add(this.cbshow);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.CheckBox cbshow;
    }
}