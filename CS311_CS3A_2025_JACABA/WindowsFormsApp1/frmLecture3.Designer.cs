namespace WindowsFormsApp1
{
    partial class frmLecture3
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmboperation = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncompute = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtinput2
            // 
            this.txtinput2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtinput2.Location = new System.Drawing.Point(123, 72);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(228, 20);
            this.txtinput2.TabIndex = 7;
            this.txtinput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput2_KeyPress);
            // 
            // txtinput1
            // 
            this.txtinput1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtinput1.Location = new System.Drawing.Point(123, 38);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(228, 20);
            this.txtinput1.TabIndex = 6;
            this.txtinput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select operation:";
            // 
            // cmboperation
            // 
            this.cmboperation.BackColor = System.Drawing.Color.Honeydew;
            this.cmboperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmboperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperation.FormattingEnabled = true;
            this.cmboperation.Items.AddRange(new object[] {
            "Add",
            "Subtract",
            "Multiply",
            "Divide"});
            this.cmboperation.Location = new System.Drawing.Point(123, 106);
            this.cmboperation.Name = "cmboperation";
            this.cmboperation.Size = new System.Drawing.Size(228, 21);
            this.cmboperation.TabIndex = 9;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(246, 145);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 30);
            this.btnreset.TabIndex = 11;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.Color.YellowGreen;
            this.btncompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(155, 145);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 30);
            this.btncompute.TabIndex = 10;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmLecture3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(393, 187);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.cmboperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.txtinput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLecture3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture3-MDAS using combobox";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboperation;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}