namespace WindowsFormsApp1
{
    partial class frmLecture1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Input number:";
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Location = new System.Drawing.Point(137, 228);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(276, 20);
            this.txtresult.TabIndex = 33;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Pink;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(264, 129);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 84);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Result:";
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.Pink;
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiv.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(147, 174);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(111, 39);
            this.btnDiv.TabIndex = 30;
            this.btnDiv.Text = "&Divide";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Input number:";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Pink;
            this.btnSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSub.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(147, 129);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(111, 39);
            this.btnSub.TabIndex = 28;
            this.btnSub.Text = "&Subtract";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.Pink;
            this.btnMul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMul.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.Location = new System.Drawing.Point(30, 174);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(111, 39);
            this.btnMul.TabIndex = 27;
            this.btnMul.Text = "&Multiply";
            this.btnMul.UseVisualStyleBackColor = false;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(110, 92);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(304, 20);
            this.txtinput2.TabIndex = 26;
            this.txtinput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput2_KeyPress_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Pink;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 39);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(110, 69);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(304, 20);
            this.txtinput1.TabIndex = 24;
            this.txtinput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinput1_KeyPress_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "CALCULATOR";
            // 
            // frmLecture1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(452, 273);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.txtinput2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtinput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLecture1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture1 - Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
    }
}