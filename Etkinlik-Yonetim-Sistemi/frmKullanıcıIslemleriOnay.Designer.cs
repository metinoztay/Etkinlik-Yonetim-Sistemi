namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmKullanıcıIslemleriOnay
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
            this.lblYetki = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblŞifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblOnaySorusu = new System.Windows.Forms.Label();
            this.btnIptal = new FontAwesome.Sharp.IconButton();
            this.btnOnay = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(133, 45);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(69, 23);
            this.lblYetki.TabIndex = 24;
            this.lblYetki.Text = "Yetki:   ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.Location = new System.Drawing.Point(125, 241);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-Mail:    ";
            // 
            // lblŞifre
            // 
            this.lblŞifre.AutoSize = true;
            this.lblŞifre.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblŞifre.Location = new System.Drawing.Point(136, 290);
            this.lblŞifre.Name = "lblŞifre";
            this.lblŞifre.Size = new System.Drawing.Size(71, 23);
            this.lblŞifre.TabIndex = 18;
            this.lblŞifre.Text = "Şifre:    ";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(78, 192);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(129, 23);
            this.lblKullaniciAdi.TabIndex = 17;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:    ";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNo.Location = new System.Drawing.Point(89, 143);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(118, 23);
            this.lblTelefonNo.TabIndex = 16;
            this.lblTelefonNo.Text = "Telefon NO:    ";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(103, 94);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(104, 23);
            this.lblAdSoyad.TabIndex = 15;
            this.lblAdSoyad.Text = "Ad Soyad:    ";
            // 
            // lblOnaySorusu
            // 
            this.lblOnaySorusu.AutoSize = true;
            this.lblOnaySorusu.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOnaySorusu.Location = new System.Drawing.Point(58, 355);
            this.lblOnaySorusu.Name = "lblOnaySorusu";
            this.lblOnaySorusu.Size = new System.Drawing.Size(389, 20);
            this.lblOnaySorusu.TabIndex = 27;
            this.lblOnaySorusu.Text = "Yukarıda verilen kullanıcı bilgileri .... onaylıyor musunuz?";
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnIptal.IconColor = System.Drawing.Color.Red;
            this.btnIptal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIptal.IconSize = 28;
            this.btnIptal.Location = new System.Drawing.Point(107, 412);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(115, 55);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOnay
            // 
            this.btnOnay.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnay.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnOnay.IconColor = System.Drawing.Color.Green;
            this.btnOnay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOnay.IconSize = 32;
            this.btnOnay.Location = new System.Drawing.Point(264, 412);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(115, 55);
            this.btnOnay.TabIndex = 25;
            this.btnOnay.Text = "ONAY";
            this.btnOnay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // frmKullanıcıIslemleriOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(196)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(490, 497);
            this.ControlBox = false;
            this.Controls.Add(this.lblOnaySorusu);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnay);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblŞifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblAdSoyad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKullanıcıIslemleriOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onay Penceresi";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblŞifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private FontAwesome.Sharp.IconButton btnOnay;
        private FontAwesome.Sharp.IconButton btnIptal;
        private System.Windows.Forms.Label lblOnaySorusu;
    }
}