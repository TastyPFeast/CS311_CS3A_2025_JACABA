namespace WindowsFormsApp1
{
    partial class frmLecture4
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
            this.components = new System.ComponentModel.Container();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncompute = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbdiv = new System.Windows.Forms.CheckBox();
            this.cbmul = new System.Windows.Forms.CheckBox();
            this.cbsub = new System.Windows.Forms.CheckBox();
            this.cbadd = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtinput2
            // 
            this.txtinput2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtinput2.Location = new System.Drawing.Point(143, 71);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(228, 20);
            this.txtinput2.TabIndex = 11;
            this.txtinput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput2_KeyPress);
            // 
            // txtinput1
            // 
            this.txtinput1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtinput1.Location = new System.Drawing.Point(143, 37);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(228, 20);
            this.txtinput1.TabIndex = 10;
            this.txtinput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input number:";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(279, 246);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 30);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.Color.YellowGreen;
            this.btncompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(188, 246);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 30);
            this.btncompute.TabIndex = 12;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbdiv);
            this.groupBox1.Controls.Add(this.cbmul);
            this.groupBox1.Controls.Add(this.cbsub);
            this.groupBox1.Controls.Add(this.cbadd);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select operation:";
            // 
            // cbdiv
            // 
            this.cbdiv.AutoSize = true;
            this.cbdiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbdiv.Location = new System.Drawing.Point(6, 88);
            this.cbdiv.Name = "cbdiv";
            this.cbdiv.Size = new System.Drawing.Size(62, 17);
            this.cbdiv.TabIndex = 3;
            this.cbdiv.Text = "Divide";
            this.cbdiv.UseVisualStyleBackColor = true;
            // 
            // cbmul
            // 
            this.cbmul.AutoSize = true;
            this.cbmul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbmul.Location = new System.Drawing.Point(6, 65);
            this.cbmul.Name = "cbmul";
            this.cbmul.Size = new System.Drawing.Size(69, 17);
            this.cbmul.TabIndex = 2;
            this.cbmul.Text = "Multiply";
            this.cbmul.UseVisualStyleBackColor = true;
            // 
            // cbsub
            // 
            this.cbsub.AutoSize = true;
            this.cbsub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbsub.Location = new System.Drawing.Point(6, 42);
            this.cbsub.Name = "cbsub";
            this.cbsub.Size = new System.Drawing.Size(74, 17);
            this.cbsub.TabIndex = 1;
            this.cbsub.Text = "Subtract";
            this.cbsub.UseVisualStyleBackColor = true;
            // 
            // cbadd
            // 
            this.cbadd.AutoSize = true;
            this.cbadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbadd.Location = new System.Drawing.Point(6, 19);
            this.cbadd.Name = "cbadd";
            this.cbadd.Size = new System.Drawing.Size(48, 17);
            this.cbadd.TabIndex = 0;
            this.cbadd.Text = "Add";
            this.cbadd.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLecture4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(435, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLecture4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture4 - MDAS using checkbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbdiv;
        private System.Windows.Forms.CheckBox cbmul;
        private System.Windows.Forms.CheckBox cbsub;
        private System.Windows.Forms.CheckBox cbadd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}