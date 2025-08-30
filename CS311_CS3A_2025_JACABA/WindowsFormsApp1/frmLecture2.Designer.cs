namespace WindowsFormsApp1
{
    partial class frmLecture2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdiv = new System.Windows.Forms.RadioButton();
            this.rbmul = new System.Windows.Forms.RadioButton();
            this.rbsub = new System.Windows.Forms.RadioButton();
            this.rbadd = new System.Windows.Forms.RadioButton();
            this.btncompute = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input number:";
            // 
            // txtinput1
            // 
            this.txtinput1.BackColor = System.Drawing.Color.LightSalmon;
            this.txtinput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput1.Location = new System.Drawing.Point(121, 41);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(228, 20);
            this.txtinput1.TabIndex = 2;
            this.txtinput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput1_KeyPress);
            // 
            // txtinput2
            // 
            this.txtinput2.BackColor = System.Drawing.Color.LightSalmon;
            this.txtinput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput2.Location = new System.Drawing.Point(121, 75);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(228, 20);
            this.txtinput2.TabIndex = 3;
            this.txtinput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput2_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdiv);
            this.groupBox1.Controls.Add(this.rbmul);
            this.groupBox1.Controls.Add(this.rbsub);
            this.groupBox1.Controls.Add(this.rbadd);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(86, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select operation:";
            // 
            // rbdiv
            // 
            this.rbdiv.AutoSize = true;
            this.rbdiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbdiv.Location = new System.Drawing.Point(87, 88);
            this.rbdiv.Name = "rbdiv";
            this.rbdiv.Size = new System.Drawing.Size(61, 17);
            this.rbdiv.TabIndex = 3;
            this.rbdiv.Text = "Divide";
            this.rbdiv.UseVisualStyleBackColor = true;
            // 
            // rbmul
            // 
            this.rbmul.AutoSize = true;
            this.rbmul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbmul.Location = new System.Drawing.Point(87, 65);
            this.rbmul.Name = "rbmul";
            this.rbmul.Size = new System.Drawing.Size(68, 17);
            this.rbmul.TabIndex = 2;
            this.rbmul.Text = "Multiply";
            this.rbmul.UseVisualStyleBackColor = true;
            // 
            // rbsub
            // 
            this.rbsub.AutoSize = true;
            this.rbsub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbsub.Location = new System.Drawing.Point(87, 42);
            this.rbsub.Name = "rbsub";
            this.rbsub.Size = new System.Drawing.Size(73, 17);
            this.rbsub.TabIndex = 1;
            this.rbsub.Text = "Subtract";
            this.rbsub.UseVisualStyleBackColor = true;
            // 
            // rbadd
            // 
            this.rbadd.AutoSize = true;
            this.rbadd.Checked = true;
            this.rbadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbadd.Location = new System.Drawing.Point(87, 19);
            this.rbadd.Name = "rbadd";
            this.rbadd.Size = new System.Drawing.Size(47, 17);
            this.rbadd.TabIndex = 0;
            this.rbadd.TabStop = true;
            this.rbadd.Text = "Add";
            this.rbadd.UseVisualStyleBackColor = true;
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.Color.Peru;
            this.btncompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(111, 254);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 33);
            this.btncompute.TabIndex = 4;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Peru;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(202, 254);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 33);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLecture2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(386, 315);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLecture2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture2-MDAS using RadioButton";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdiv;
        private System.Windows.Forms.RadioButton rbmul;
        private System.Windows.Forms.RadioButton rbsub;
        private System.Windows.Forms.RadioButton rbadd;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}