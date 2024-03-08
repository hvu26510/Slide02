namespace TruyenDuLieu
{
    partial class NhapDuLieu
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnC1
            // 
            this.btnC1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC1.Location = new System.Drawing.Point(36, 107);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(75, 23);
            this.btnC1.TabIndex = 1;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = true;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // btnC2
            // 
            this.btnC2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC2.Location = new System.Drawing.Point(154, 107);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(75, 23);
            this.btnC2.TabIndex = 2;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = true;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC3
            // 
            this.btnC3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC3.Location = new System.Drawing.Point(276, 107);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(75, 23);
            this.btnC3.TabIndex = 3;
            this.btnC3.Text = "C3";
            this.btnC3.UseVisualStyleBackColor = true;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnC4
            // 
            this.btnC4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnC4.Location = new System.Drawing.Point(390, 107);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(75, 23);
            this.btnC4.TabIndex = 4;
            this.btnC4.Text = "C4";
            this.btnC4.UseVisualStyleBackColor = true;
            this.btnC4.Click += new System.EventHandler(this.btnC4_Click);
            // 
            // NhapDuLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 179);
            this.Controls.Add(this.btnC4);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.textBox1);
            this.Name = "NhapDuLieu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC4;
        public System.Windows.Forms.TextBox textBox1;
    }
}

