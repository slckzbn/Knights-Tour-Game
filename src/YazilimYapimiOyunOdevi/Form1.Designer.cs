namespace YazilimYapimiOyunOdevi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnYeni = new System.Windows.Forms.Button();
            this.lblHamleSayisi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.rd9x9 = new System.Windows.Forms.RadioButton();
            this.rd8x8 = new System.Windows.Forms.RadioButton();
            this.rd7x7 = new System.Windows.Forms.RadioButton();
            this.rd6x6 = new System.Windows.Forms.RadioButton();
            this.rd5x5 = new System.Windows.Forms.RadioButton();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(32, 13);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(75, 23);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni Oyun";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // lblHamleSayisi
            // 
            this.lblHamleSayisi.AutoSize = true;
            this.lblHamleSayisi.Location = new System.Drawing.Point(143, 18);
            this.lblHamleSayisi.Name = "lblHamleSayisi";
            this.lblHamleSayisi.Size = new System.Drawing.Size(82, 13);
            this.lblHamleSayisi.TabIndex = 1;
            this.lblHamleSayisi.Text = "Hamle Sayısı : 0";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(32, 350);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 2;
            // 
            // rd9x9
            // 
            this.rd9x9.AutoSize = true;
            this.rd9x9.Location = new System.Drawing.Point(372, 140);
            this.rd9x9.Name = "rd9x9";
            this.rd9x9.Size = new System.Drawing.Size(42, 17);
            this.rd9x9.TabIndex = 12;
            this.rd9x9.Text = "9x9";
            this.rd9x9.UseVisualStyleBackColor = true;
            this.rd9x9.CheckedChanged += new System.EventHandler(this.rd9x9_CheckedChanged);
            // 
            // rd8x8
            // 
            this.rd8x8.AutoSize = true;
            this.rd8x8.Location = new System.Drawing.Point(372, 117);
            this.rd8x8.Name = "rd8x8";
            this.rd8x8.Size = new System.Drawing.Size(42, 17);
            this.rd8x8.TabIndex = 13;
            this.rd8x8.Text = "8x8";
            this.rd8x8.UseVisualStyleBackColor = true;
            this.rd8x8.CheckedChanged += new System.EventHandler(this.rd8x8_CheckedChanged);
            // 
            // rd7x7
            // 
            this.rd7x7.AutoSize = true;
            this.rd7x7.Location = new System.Drawing.Point(372, 94);
            this.rd7x7.Name = "rd7x7";
            this.rd7x7.Size = new System.Drawing.Size(42, 17);
            this.rd7x7.TabIndex = 14;
            this.rd7x7.Text = "7x7";
            this.rd7x7.UseVisualStyleBackColor = true;
            this.rd7x7.CheckedChanged += new System.EventHandler(this.rd7x7_CheckedChanged);
            // 
            // rd6x6
            // 
            this.rd6x6.AutoSize = true;
            this.rd6x6.Location = new System.Drawing.Point(372, 71);
            this.rd6x6.Name = "rd6x6";
            this.rd6x6.Size = new System.Drawing.Size(42, 17);
            this.rd6x6.TabIndex = 15;
            this.rd6x6.Text = "6x6";
            this.rd6x6.UseVisualStyleBackColor = true;
            this.rd6x6.CheckedChanged += new System.EventHandler(this.rd6x6_CheckedChanged);
            // 
            // rd5x5
            // 
            this.rd5x5.AutoSize = true;
            this.rd5x5.Checked = true;
            this.rd5x5.Location = new System.Drawing.Point(372, 48);
            this.rd5x5.Name = "rd5x5";
            this.rd5x5.Size = new System.Drawing.Size(42, 17);
            this.rd5x5.TabIndex = 16;
            this.rd5x5.TabStop = true;
            this.rd5x5.Text = "5x5";
            this.rd5x5.UseVisualStyleBackColor = true;
            this.rd5x5.CheckedChanged += new System.EventHandler(this.rd5x5_CheckedChanged_1);
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Location = new System.Drawing.Point(369, 18);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(103, 13);
            this.lblBoyut.TabIndex = 11;
            this.lblBoyut.Text = "Oyun Alanını Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 395);
            this.Controls.Add(this.rd9x9);
            this.Controls.Add(this.rd8x8);
            this.Controls.Add(this.rd7x7);
            this.Controls.Add(this.rd6x6);
            this.Controls.Add(this.rd5x5);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblHamleSayisi);
            this.Controls.Add(this.btnYeni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "At Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Label lblHamleSayisi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.RadioButton rd9x9;
        private System.Windows.Forms.RadioButton rd8x8;
        private System.Windows.Forms.RadioButton rd7x7;
        private System.Windows.Forms.RadioButton rd6x6;
        private System.Windows.Forms.RadioButton rd5x5;
        private System.Windows.Forms.Label lblBoyut;
    }
}

