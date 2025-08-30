namespace WindowsFormsApp1
{
    partial class PracticePrelimExam
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkpagibig = new System.Windows.Forms.CheckBox();
            this.chkphilhealth = new System.Windows.Forms.CheckBox();
            this.chksss = new System.Windows.Forms.CheckBox();
            this.btncompute = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.restax = new System.Windows.Forms.TextBox();
            this.resSSS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resphilhealth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.respagibig = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resgrosspay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.resTotalpay = new System.Windows.Forms.TextBox();
            this.txtadditional = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.resNetpay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.restotaldeduc = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input employee rate: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input number of hours worked: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee status: ";
            // 
            // cmbstatus
            // 
            this.cmbstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Full-time",
            "Part-time",
            "Contractual"});
            this.cmbstatus.Location = new System.Drawing.Point(183, 75);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(200, 21);
            this.cmbstatus.TabIndex = 3;
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(183, 26);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(200, 20);
            this.txtrate.TabIndex = 4;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(183, 49);
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(200, 20);
            this.txthours.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkpagibig);
            this.groupBox1.Controls.Add(this.chkphilhealth);
            this.groupBox1.Controls.Add(this.chksss);
            this.groupBox1.Location = new System.Drawing.Point(183, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select deduction/s:";
            // 
            // chkpagibig
            // 
            this.chkpagibig.AutoSize = true;
            this.chkpagibig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkpagibig.Location = new System.Drawing.Point(60, 42);
            this.chkpagibig.Name = "chkpagibig";
            this.chkpagibig.Size = new System.Drawing.Size(61, 17);
            this.chkpagibig.TabIndex = 10;
            this.chkpagibig.Text = "Pagibig";
            this.chkpagibig.UseVisualStyleBackColor = true;
            // 
            // chkphilhealth
            // 
            this.chkphilhealth.AutoSize = true;
            this.chkphilhealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkphilhealth.Location = new System.Drawing.Point(59, 65);
            this.chkphilhealth.Name = "chkphilhealth";
            this.chkphilhealth.Size = new System.Drawing.Size(72, 17);
            this.chkphilhealth.TabIndex = 9;
            this.chkphilhealth.Text = "Philhealth";
            this.chkphilhealth.UseVisualStyleBackColor = true;
            // 
            // chksss
            // 
            this.chksss.AutoSize = true;
            this.chksss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chksss.Location = new System.Drawing.Point(59, 19);
            this.chksss.Name = "chksss";
            this.chksss.Size = new System.Drawing.Size(47, 17);
            this.chksss.TabIndex = 7;
            this.chksss.Text = "SSS";
            this.chksss.UseVisualStyleBackColor = true;
            // 
            // btncompute
            // 
            this.btncompute.Location = new System.Drawing.Point(308, 227);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 23);
            this.btncompute.TabIndex = 7;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.restax);
            this.groupBox2.Controls.Add(this.resSSS);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.resphilhealth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.respagibig);
            this.groupBox2.Location = new System.Drawing.Point(440, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 145);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details of deductions:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "SSS";
            // 
            // restax
            // 
            this.restax.Location = new System.Drawing.Point(76, 102);
            this.restax.Name = "restax";
            this.restax.Size = new System.Drawing.Size(162, 20);
            this.restax.TabIndex = 16;
            // 
            // resSSS
            // 
            this.resSSS.Location = new System.Drawing.Point(76, 76);
            this.resSSS.Name = "resSSS";
            this.resSSS.Size = new System.Drawing.Size(162, 20);
            this.resSSS.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Philhealth";
            // 
            // resphilhealth
            // 
            this.resphilhealth.Location = new System.Drawing.Point(76, 50);
            this.resphilhealth.Name = "resphilhealth";
            this.resphilhealth.Size = new System.Drawing.Size(162, 20);
            this.resphilhealth.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pagibig";
            // 
            // respagibig
            // 
            this.respagibig.Location = new System.Drawing.Point(76, 24);
            this.respagibig.Name = "respagibig";
            this.respagibig.Size = new System.Drawing.Size(162, 20);
            this.respagibig.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Gross pay:";
            // 
            // resgrosspay
            // 
            this.resgrosspay.Location = new System.Drawing.Point(478, 23);
            this.resgrosspay.Name = "resgrosspay";
            this.resgrosspay.Size = new System.Drawing.Size(200, 20);
            this.resgrosspay.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total pay: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Additional:";
            // 
            // resTotalpay
            // 
            this.resTotalpay.Location = new System.Drawing.Point(516, 288);
            this.resTotalpay.Name = "resTotalpay";
            this.resTotalpay.Size = new System.Drawing.Size(162, 20);
            this.resTotalpay.TabIndex = 23;
            // 
            // txtadditional
            // 
            this.txtadditional.Location = new System.Drawing.Point(516, 262);
            this.txtadditional.Name = "txtadditional";
            this.txtadditional.Size = new System.Drawing.Size(162, 20);
            this.txtadditional.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Net pay: ";
            // 
            // resNetpay
            // 
            this.resNetpay.Location = new System.Drawing.Point(516, 236);
            this.resNetpay.Name = "resNetpay";
            this.resNetpay.Size = new System.Drawing.Size(162, 20);
            this.resNetpay.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(419, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total Deductions:";
            // 
            // restotaldeduc
            // 
            this.restotaldeduc.Location = new System.Drawing.Point(516, 210);
            this.restotaldeduc.Name = "restotaldeduc";
            this.restotaldeduc.Size = new System.Drawing.Size(162, 20);
            this.restotaldeduc.TabIndex = 20;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(603, 348);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 27;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PracticePrelimExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 440);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resgrosspay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resTotalpay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtadditional);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resNetpay);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.restotaldeduc);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PracticePrelimExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PracticePrelimExam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkphilhealth;
        private System.Windows.Forms.CheckBox chksss;
        private System.Windows.Forms.CheckBox chkpagibig;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox restax;
        private System.Windows.Forms.TextBox resSSS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox resphilhealth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox respagibig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resgrosspay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resTotalpay;
        private System.Windows.Forms.TextBox txtadditional;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox resNetpay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox restotaldeduc;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}