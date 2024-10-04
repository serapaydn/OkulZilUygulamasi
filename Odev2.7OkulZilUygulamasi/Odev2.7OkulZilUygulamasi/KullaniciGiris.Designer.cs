namespace Odev2._7OkulZilUygulamasi
{
    partial class KullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGiris));
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_kullaniciadi = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_giris.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_giris.Location = new System.Drawing.Point(78, 183);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(243, 30);
            this.btn_giris.TabIndex = 9;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_sifre.Location = new System.Drawing.Point(78, 132);
            this.tb_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.PasswordChar = '*';
            this.tb_sifre.Size = new System.Drawing.Size(243, 26);
            this.tb_sifre.TabIndex = 8;
            // 
            // tb_kullaniciadi
            // 
            this.tb_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kullaniciadi.Location = new System.Drawing.Point(78, 71);
            this.tb_kullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_kullaniciadi.Name = "tb_kullaniciadi";
            this.tb_kullaniciadi.Size = new System.Drawing.Size(243, 26);
            this.tb_kullaniciadi.TabIndex = 6;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbl_sifre.Location = new System.Drawing.Point(78, 101);
            this.lbl_sifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(46, 21);
            this.lbl_sifre.TabIndex = 7;
            this.lbl_sifre.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 273);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tb_sifre);
            this.Controls.Add(this.tb_kullaniciadi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 320);
            this.MinimumSize = new System.Drawing.Size(420, 320);
            this.Name = "KullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okul Zil Sistem Kullanıcı Girişi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KullaniciGiris_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KullaniciGiris_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_kullaniciadi;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Label label1;
    }
}