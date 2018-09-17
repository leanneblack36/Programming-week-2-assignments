namespace Assignment4
{
    partial class Assignment4
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
            this.btnVAT = new System.Windows.Forms.Button();
            this.txtEnterPrice = new System.Windows.Forms.TextBox();
            this.lblenterprice = new System.Windows.Forms.Label();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtDisplayPrice = new System.Windows.Forms.TextBox();
            this.txtShowVAT = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVAT
            // 
            this.btnVAT.Location = new System.Drawing.Point(125, 136);
            this.btnVAT.Name = "btnVAT";
            this.btnVAT.Size = new System.Drawing.Size(345, 35);
            this.btnVAT.TabIndex = 0;
            this.btnVAT.Text = "Determine VAT";
            this.btnVAT.UseVisualStyleBackColor = true;
            this.btnVAT.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnterPrice
            // 
            this.txtEnterPrice.Location = new System.Drawing.Point(286, 66);
            this.txtEnterPrice.Name = "txtEnterPrice";
            this.txtEnterPrice.Size = new System.Drawing.Size(100, 22);
            this.txtEnterPrice.TabIndex = 1;
            this.txtEnterPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblenterprice
            // 
            this.lblenterprice.AutoSize = true;
            this.lblenterprice.Location = new System.Drawing.Point(71, 66);
            this.lblenterprice.Name = "lblenterprice";
            this.lblenterprice.Size = new System.Drawing.Size(89, 17);
            this.lblenterprice.TabIndex = 2;
            this.lblenterprice.Text = "Enter a price";
            this.lblenterprice.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.Location = new System.Drawing.Point(80, 269);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(44, 17);
            this.lblShowPrice.TabIndex = 3;
            this.lblShowPrice.Text = "Price:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(80, 325);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(39, 17);
            this.lblVAT.TabIndex = 4;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(79, 393);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // txtDisplayPrice
            // 
            this.txtDisplayPrice.Location = new System.Drawing.Point(271, 261);
            this.txtDisplayPrice.Name = "txtDisplayPrice";
            this.txtDisplayPrice.Size = new System.Drawing.Size(114, 22);
            this.txtDisplayPrice.TabIndex = 6;
            // 
            // txtShowVAT
            // 
            this.txtShowVAT.Location = new System.Drawing.Point(273, 319);
            this.txtShowVAT.Name = "txtShowVAT";
            this.txtShowVAT.Size = new System.Drawing.Size(111, 22);
            this.txtShowVAT.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(278, 394);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(106, 22);
            this.txtTotal.TabIndex = 8;
            // 
            // Assignment4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtShowVAT);
            this.Controls.Add(this.txtDisplayPrice);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblShowPrice);
            this.Controls.Add(this.lblenterprice);
            this.Controls.Add(this.txtEnterPrice);
            this.Controls.Add(this.btnVAT);
            this.Name = "Assignment4";
            this.Text = "VAT:";
            this.Load += new System.EventHandler(this.Assignment4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVAT;
        private System.Windows.Forms.TextBox txtEnterPrice;
        private System.Windows.Forms.Label lblenterprice;
        private System.Windows.Forms.Label lblShowPrice;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDisplayPrice;
        private System.Windows.Forms.TextBox txtShowVAT;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

