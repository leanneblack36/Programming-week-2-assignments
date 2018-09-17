namespace Assignment_5
{
    partial class Assignment5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtThree = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAvrg = new System.Windows.Forms.Label();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number 3:";
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(244, 70);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(139, 22);
            this.txtOne.TabIndex = 3;
            this.txtOne.TextChanged += new System.EventHandler(this.txtNo1_TextChanged);
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(247, 123);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(135, 22);
            this.txtTwo.TabIndex = 4;
            // 
            // txtThree
            // 
            this.txtThree.Location = new System.Drawing.Point(247, 174);
            this.txtThree.Name = "txtThree";
            this.txtThree.Size = new System.Drawing.Size(135, 22);
            this.txtThree.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(289, 33);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAvrg
            // 
            this.txtAvrg.AutoSize = true;
            this.txtAvrg.Location = new System.Drawing.Point(100, 335);
            this.txtAvrg.Name = "txtAvrg";
            this.txtAvrg.Size = new System.Drawing.Size(65, 17);
            this.txtAvrg.TabIndex = 7;
            this.txtAvrg.Text = "Average:";
            // 
            // txtAverage
            // 
            this.txtAverage.BackColor = System.Drawing.SystemColors.Menu;
            this.txtAverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAverage.Location = new System.Drawing.Point(241, 339);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.Size = new System.Drawing.Size(141, 15);
            this.txtAverage.TabIndex = 8;
            // 
            // Assignment5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 396);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtAvrg);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtThree);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Assignment5";
            this.Text = "txtAverage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtThree;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label txtAvrg;
        private System.Windows.Forms.TextBox txtAverage;
    }
}

