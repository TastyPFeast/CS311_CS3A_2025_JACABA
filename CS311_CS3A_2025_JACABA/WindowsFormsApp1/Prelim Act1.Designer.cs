namespace WindowsFormsApp1
{
    partial class Act1
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtareares = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerimeter = new System.Windows.Forms.Button();
            this.btnComputeall = new System.Windows.Forms.Button();
            this.txtsideB = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.txtsideA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtheight = new System.Windows.Forms.TextBox();
            this.txtsideC = new System.Windows.Forms.TextBox();
            this.txtperimeterres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 34);
            this.label5.TabIndex = 47;
            this.label5.Text = "CALCULATOR - TRIGONOMETRIC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Input sideB:";
            // 
            // txtareares
            // 
            this.txtareares.Enabled = false;
            this.txtareares.Location = new System.Drawing.Point(129, 341);
            this.txtareares.Name = "txtareares";
            this.txtareares.Size = new System.Drawing.Size(243, 20);
            this.txtareares.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Pink;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(257, 262);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 63);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Area:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Input sideA:";
            // 
            // btnPerimeter
            // 
            this.btnPerimeter.BackColor = System.Drawing.Color.Pink;
            this.btnPerimeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerimeter.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerimeter.Location = new System.Drawing.Point(257, 193);
            this.btnPerimeter.Name = "btnPerimeter";
            this.btnPerimeter.Size = new System.Drawing.Size(95, 63);
            this.btnPerimeter.TabIndex = 40;
            this.btnPerimeter.Text = "&Perimeter";
            this.btnPerimeter.UseVisualStyleBackColor = false;
            this.btnPerimeter.Click += new System.EventHandler(this.btnPerimeter_Click);
            // 
            // btnComputeall
            // 
            this.btnComputeall.BackColor = System.Drawing.Color.Pink;
            this.btnComputeall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComputeall.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeall.Location = new System.Drawing.Point(156, 262);
            this.btnComputeall.Name = "btnComputeall";
            this.btnComputeall.Size = new System.Drawing.Size(95, 63);
            this.btnComputeall.TabIndex = 39;
            this.btnComputeall.Text = "&Compute All";
            this.btnComputeall.UseVisualStyleBackColor = false;
            this.btnComputeall.Click += new System.EventHandler(this.btnComputeall_Click);
            // 
            // txtsideB
            // 
            this.txtsideB.Location = new System.Drawing.Point(129, 110);
            this.txtsideB.Name = "txtsideB";
            this.txtsideB.Size = new System.Drawing.Size(243, 20);
            this.txtsideB.TabIndex = 38;
            this.txtsideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsideB_KeyPress);
            // 
            // btnArea
            // 
            this.btnArea.BackColor = System.Drawing.Color.Pink;
            this.btnArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArea.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArea.Location = new System.Drawing.Point(154, 193);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(97, 63);
            this.btnArea.TabIndex = 37;
            this.btnArea.Text = "&Area";
            this.btnArea.UseVisualStyleBackColor = false;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // txtsideA
            // 
            this.txtsideA.Location = new System.Drawing.Point(129, 87);
            this.txtsideA.Name = "txtsideA";
            this.txtsideA.Size = new System.Drawing.Size(243, 20);
            this.txtsideA.TabIndex = 36;
            this.txtsideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsideA_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Input Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Input sideC:";
            // 
            // txtheight
            // 
            this.txtheight.Location = new System.Drawing.Point(129, 159);
            this.txtheight.Name = "txtheight";
            this.txtheight.Size = new System.Drawing.Size(243, 20);
            this.txtheight.TabIndex = 49;
            this.txtheight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtheight_KeyPress);
            // 
            // txtsideC
            // 
            this.txtsideC.Location = new System.Drawing.Point(129, 136);
            this.txtsideC.Name = "txtsideC";
            this.txtsideC.Size = new System.Drawing.Size(243, 20);
            this.txtsideC.TabIndex = 48;
            this.txtsideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsideC_KeyPress);
            // 
            // txtperimeterres
            // 
            this.txtperimeterres.Enabled = false;
            this.txtperimeterres.Location = new System.Drawing.Point(129, 367);
            this.txtperimeterres.Name = "txtperimeterres";
            this.txtperimeterres.Size = new System.Drawing.Size(243, 20);
            this.txtperimeterres.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 52;
            this.label7.Text = "Perimeter:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Act1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(449, 413);
            this.Controls.Add(this.txtperimeterres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtheight);
            this.Controls.Add(this.txtsideC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtareares);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPerimeter);
            this.Controls.Add(this.btnComputeall);
            this.Controls.Add(this.txtsideB);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtsideA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Act1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prelim Activity 1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtareares;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerimeter;
        private System.Windows.Forms.Button btnComputeall;
        private System.Windows.Forms.TextBox txtsideB;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox txtsideA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtheight;
        private System.Windows.Forms.TextBox txtsideC;
        private System.Windows.Forms.TextBox txtperimeterres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}