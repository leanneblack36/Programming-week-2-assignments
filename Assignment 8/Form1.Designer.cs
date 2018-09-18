namespace Assignment_8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTshirts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJeans = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalprice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of T-shirts (x € 30.00):";
            // 
            // txtTshirts
            // 
            this.txtTshirts.Location = new System.Drawing.Point(263, 33);
            this.txtTshirts.Name = "txtTshirts";
            this.txtTshirts.Size = new System.Drawing.Size(130, 22);
            this.txtTshirts.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of jeans (x €100.00):";
            // 
            // txtJeans
            // 
            this.txtJeans.Location = new System.Drawing.Point(263, 85);
            this.txtJeans.Name = "txtJeans";
            this.txtJeans.Size = new System.Drawing.Size(129, 22);
            this.txtJeans.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(38, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(354, 68);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invoice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "VAT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total price:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(178, 272);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(83, 17);
            this.lblDateTime.TabIndex = 10;
            this.lblDateTime.Text = "lblDateTime";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(178, 319);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "lblPrice";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(180, 357);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(49, 17);
            this.lblVAT.TabIndex = 12;
            this.lblVAT.Text = "lblVAT";
            // 
            // lblTotalprice
            // 
            this.lblTotalprice.AutoSize = true;
            this.lblTotalprice.Location = new System.Drawing.Point(183, 406);
            this.lblTotalprice.Name = "lblTotalprice";
            this.lblTotalprice.Size = new System.Drawing.Size(85, 17);
            this.lblTotalprice.TabIndex = 13;
            this.lblTotalprice.Text = "lblTotalprice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalprice);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtJeans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTshirts);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTshirts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJeans;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotalprice;
    }
}

