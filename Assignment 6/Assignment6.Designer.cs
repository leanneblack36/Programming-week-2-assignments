namespace Assignment_6
{
    partial class Assignment6
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
            this.txtEnteredSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnteredSeconds
            // 
            this.txtEnteredSeconds.Location = new System.Drawing.Point(327, 44);
            this.txtEnteredSeconds.Name = "txtEnteredSeconds";
            this.txtEnteredSeconds.Size = new System.Drawing.Size(152, 22);
            this.txtEnteredSeconds.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seconds:";
            // 
            // btnCalculateTime
            // 
            this.btnCalculateTime.Location = new System.Drawing.Point(157, 133);
            this.btnCalculateTime.Name = "btnCalculateTime";
            this.btnCalculateTime.Size = new System.Drawing.Size(337, 50);
            this.btnCalculateTime.TabIndex = 2;
            this.btnCalculateTime.Text = "Calculate Time";
            this.btnCalculateTime.UseVisualStyleBackColor = true;
            this.btnCalculateTime.Click += new System.EventHandler(this.btnCalculateTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "hours: minutes: seconds:";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(115, 336);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 17);
            this.lblFinal.TabIndex = 7;
            // 
            // Assignment6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculateTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnteredSeconds);
            this.Name = "Assignment6";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnteredSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinal;
    }
}

