namespace WindowsFormsApp1
{
    partial class Prelim_Act_2
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
            this.btnreset = new System.Windows.Forms.Button();
            this.cmboperation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtopp = new System.Windows.Forms.TextBox();
            this.txthy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hypo = new System.Windows.Forms.Label();
            this.txtadj = new System.Windows.Forms.TextBox();
            this.adja = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btncompute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.YellowGreen;
            this.btnreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(267, 165);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 30);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "&Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cmboperation
            // 
            this.cmboperation.BackColor = System.Drawing.Color.Honeydew;
            this.cmboperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmboperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboperation.FormattingEnabled = true;
            this.cmboperation.Items.AddRange(new object[] {
            "Sine ",
            "Cosine",
            "Tangent",
            "Compute All"});
            this.cmboperation.Location = new System.Drawing.Point(144, 126);
            this.cmboperation.Name = "cmboperation";
            this.cmboperation.Size = new System.Drawing.Size(228, 21);
            this.cmboperation.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select operation:";
            // 
            // txtopp
            // 
            this.txtopp.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtopp.Location = new System.Drawing.Point(144, 92);
            this.txtopp.Name = "txtopp";
            this.txtopp.Size = new System.Drawing.Size(228, 20);
            this.txtopp.TabIndex = 15;
            this.txtopp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtopp_KeyPress);
            // 
            // txthy
            // 
            this.txthy.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txthy.Location = new System.Drawing.Point(144, 58);
            this.txthy.Name = "txthy";
            this.txthy.Size = new System.Drawing.Size(228, 20);
            this.txthy.TabIndex = 14;
            this.txthy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txthy_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Opposite Side:";
            // 
            // hypo
            // 
            this.hypo.AutoSize = true;
            this.hypo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hypo.Location = new System.Drawing.Point(59, 61);
            this.hypo.Name = "hypo";
            this.hypo.Size = new System.Drawing.Size(78, 13);
            this.hypo.TabIndex = 12;
            this.hypo.Text = "Hypotenuse:";
            // 
            // txtadj
            // 
            this.txtadj.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtadj.Location = new System.Drawing.Point(144, 22);
            this.txtadj.Name = "txtadj";
            this.txtadj.Size = new System.Drawing.Size(228, 20);
            this.txtadj.TabIndex = 21;
            this.txtadj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadj_KeyPress);
            // 
            // adja
            // 
            this.adja.AutoSize = true;
            this.adja.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adja.Location = new System.Drawing.Point(52, 25);
            this.adja.Name = "adja";
            this.adja.Size = new System.Drawing.Size(90, 13);
            this.adja.TabIndex = 20;
            this.adja.Text = "Adjacent Side:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btncompute
            // 
            this.btncompute.BackColor = System.Drawing.Color.YellowGreen;
            this.btncompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompute.Location = new System.Drawing.Point(176, 165);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 30);
            this.btncompute.TabIndex = 22;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = false;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // Prelim_Act_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(448, 219);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.txtadj);
            this.Controls.Add(this.adja);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.cmboperation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtopp);
            this.Controls.Add(this.txthy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hypo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Prelim_Act_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prelim-Activity 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ComboBox cmboperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtopp;
        private System.Windows.Forms.TextBox txthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hypo;
        private System.Windows.Forms.TextBox txtadj;
        private System.Windows.Forms.Label adja;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btncompute;
    }
}