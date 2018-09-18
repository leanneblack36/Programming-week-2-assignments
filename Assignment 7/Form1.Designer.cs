namespace Assignment_7
{
    partial class Form1
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
            this.txtStartkm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndkm = new System.Windows.Forms.TextBox();
            this.txtPricekm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPriceexVAT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblShowVAT = new System.Windows.Forms.Label();
            this.lblPriceincVAT = new System.Windows.Forms.Label();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartkm
            // 
            this.txtStartkm.Location = new System.Drawing.Point(232, 36);
            this.txtStartkm.Name = "txtStartkm";
            this.txtStartkm.Size = new System.Drawing.Size(105, 22);
            this.txtStartkm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start km";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "End km";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price / km";
            // 
            // txtEndkm
            // 
            this.txtEndkm.Location = new System.Drawing.Point(233, 89);
            this.txtEndkm.Name = "txtEndkm";
            this.txtEndkm.Size = new System.Drawing.Size(103, 22);
            this.txtEndkm.TabIndex = 4;
            // 
            // txtPricekm
            // 
            this.txtPricekm.Location = new System.Drawing.Point(233, 138);
            this.txtPricekm.Name = "txtPricekm";
            this.txtPricekm.Size = new System.Drawing.Size(103, 22);
            this.txtPricekm.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price excl VAT";
            // 
            // lblPriceexVAT
            // 
            this.lblPriceexVAT.AutoSize = true;
            this.lblPriceexVAT.Location = new System.Drawing.Point(71, 291);
            this.lblPriceexVAT.Name = "lblPriceexVAT";
            this.lblPriceexVAT.Size = new System.Drawing.Size(0, 17);
            this.lblPriceexVAT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "VAT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price incl VAT";
            // 
            // lblShowVAT
            // 
            this.lblShowVAT.AutoSize = true;
            this.lblShowVAT.Location = new System.Drawing.Point(236, 292);
            this.lblShowVAT.Name = "lblShowVAT";
            this.lblShowVAT.Size = new System.Drawing.Size(0, 17);
            this.lblShowVAT.TabIndex = 10;
            // 
            // lblPriceincVAT
            // 
            this.lblPriceincVAT.AutoSize = true;
            this.lblPriceincVAT.Location = new System.Drawing.Point(352, 292);
            this.lblPriceincVAT.Name = "lblPriceincVAT";
            this.lblPriceincVAT.Size = new System.Drawing.Size(0, 17);
            this.lblPriceincVAT.TabIndex = 11;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(385, 37);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(136, 43);
            this.btnErase.TabIndex = 12;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(387, 148);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 44);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.lblPriceincVAT);
            this.Controls.Add(this.lblShowVAT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPriceexVAT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPricekm);
            this.Controls.Add(this.txtEndkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartkm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartkm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEndkm;
        private System.Windows.Forms.TextBox txtPricekm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPriceexVAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblShowVAT;
        private System.Windows.Forms.Label lblPriceincVAT;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnCalculate;
    }
}

