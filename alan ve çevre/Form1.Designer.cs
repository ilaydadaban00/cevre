namespace alan_ve_çevre
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
            this.btnSonuc = new System.Windows.Forms.Button();
            this.txtKenar1 = new System.Windows.Forms.TextBox();
            this.txtKenar2 = new System.Windows.Forms.TextBox();
            this.lblKenar = new System.Windows.Forms.Label();
            this.lblcevre = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(49, 113);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(124, 23);
            this.btnSonuc.TabIndex = 0;
            this.btnSonuc.Text = "sonuc";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKenar1
            // 
            this.txtKenar1.Location = new System.Drawing.Point(49, 49);
            this.txtKenar1.Name = "txtKenar1";
            this.txtKenar1.Size = new System.Drawing.Size(100, 20);
            this.txtKenar1.TabIndex = 1;
            this.txtKenar1.TabStop = false;
            // 
            // txtKenar2
            // 
            this.txtKenar2.Location = new System.Drawing.Point(49, 75);
            this.txtKenar2.Name = "txtKenar2";
            this.txtKenar2.Size = new System.Drawing.Size(100, 20);
            this.txtKenar2.TabIndex = 3;
            // 
            // lblKenar
            // 
            this.lblKenar.AutoSize = true;
            this.lblKenar.Location = new System.Drawing.Point(193, 55);
            this.lblKenar.Name = "lblKenar";
            this.lblKenar.Size = new System.Drawing.Size(43, 13);
            this.lblKenar.TabIndex = 5;
            this.lblKenar.Text = "k kenar";
            // 
            // lblcevre
            // 
            this.lblcevre.AutoSize = true;
            this.lblcevre.Location = new System.Drawing.Point(46, 240);
            this.lblcevre.Name = "lblcevre";
            this.lblcevre.Size = new System.Drawing.Size(34, 13);
            this.lblcevre.TabIndex = 6;
            this.lblcevre.Text = "çevre";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(46, 202);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(27, 13);
            this.lblAlan.TabIndex = 7;
            this.lblAlan.Text = "alan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "u kenar";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(96, 156);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(106, 13);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "alan ve hesap sonuc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 277);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblcevre);
            this.Controls.Add(this.lblKenar);
            this.Controls.Add(this.txtKenar2);
            this.Controls.Add(this.txtKenar1);
            this.Controls.Add(this.btnSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.TextBox txtKenar1;
        private System.Windows.Forms.TextBox txtKenar2;
        private System.Windows.Forms.Label lblKenar;
        private System.Windows.Forms.Label lblcevre;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSonuc;
    }
}

