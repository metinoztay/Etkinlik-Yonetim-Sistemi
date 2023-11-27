namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmPersonel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxKullaniciID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxYetkiListesi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.listKullanicilar = new System.Windows.Forms.ListView();
            this.KullaniciID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdiSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KullaniciAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxŞifre = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbxTelNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAdSoyad = new System.Windows.Forms.TextBox();
            this.cbxYetki = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxKullaniciID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboxYetkiListesi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.listKullanicilar);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxŞifre);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.tbxKullaniciAdi);
            this.panel1.Controls.Add(this.tbxTelNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxAdSoyad);
            this.panel1.Controls.Add(this.cbxYetki);
            this.panel1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 657);
            this.panel1.TabIndex = 0;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(951, 129);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(126, 35);
            this.btnDuzenle.TabIndex = 23;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(149, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Kullanıcı Bilgileri";
            // 
            // tbxKullaniciID
            // 
            this.tbxKullaniciID.Enabled = false;
            this.tbxKullaniciID.Location = new System.Drawing.Point(148, 129);
            this.tbxKullaniciID.Name = "tbxKullaniciID";
            this.tbxKullaniciID.Size = new System.Drawing.Size(285, 25);
            this.tbxKullaniciID.TabIndex = 21;
            this.tbxKullaniciID.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(450, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Yetki";
            // 
            // cboxYetkiListesi
            // 
            this.cboxYetkiListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxYetkiListesi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxYetkiListesi.FormattingEnabled = true;
            this.cboxYetkiListesi.Items.AddRange(new object[] {
            "Tümü",
            "Yönetici",
            "Kullanıcı",
            "Personel"});
            this.cboxYetkiListesi.Location = new System.Drawing.Point(504, 131);
            this.cboxYetkiListesi.Name = "cboxYetkiListesi";
            this.cboxYetkiListesi.Size = new System.Drawing.Size(275, 31);
            this.cboxYetkiListesi.TabIndex = 19;
            this.cboxYetkiListesi.Text = "Seçim Yapınız.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(450, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kullanıcı Listesi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(148, 511);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(285, 35);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(148, 470);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(131, 35);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetir.Location = new System.Drawing.Point(785, 129);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(160, 35);
            this.btnGetir.TabIndex = 15;
            this.btnGetir.Text = "GETİR";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // listKullanicilar
            // 
            this.listKullanicilar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKullanicilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KullaniciID,
            this.AdiSoyadi,
            this.TelefonNO,
            this.KullaniciAdi,
            this.columnHeader4});
            this.listKullanicilar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKullanicilar.FullRowSelect = true;
            this.listKullanicilar.HideSelection = false;
            this.listKullanicilar.Location = new System.Drawing.Point(449, 170);
            this.listKullanicilar.Name = "listKullanicilar";
            this.listKullanicilar.Scrollable = false;
            this.listKullanicilar.Size = new System.Drawing.Size(628, 376);
            this.listKullanicilar.TabIndex = 14;
            this.listKullanicilar.UseCompatibleStateImageBehavior = false;
            this.listKullanicilar.View = System.Windows.Forms.View.Details;
            this.listKullanicilar.SelectedIndexChanged += new System.EventHandler(this.listKullanicilar_SelectedIndexChanged);
            // 
            // KullaniciID
            // 
            this.KullaniciID.DisplayIndex = 4;
            this.KullaniciID.Text = "";
            this.KullaniciID.Width = 0;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DisplayIndex = 0;
            this.AdiSoyadi.Text = "Ad Soyad";
            this.AdiSoyadi.Width = 256;
            // 
            // TelefonNO
            // 
            this.TelefonNO.DisplayIndex = 1;
            this.TelefonNO.Text = "Telefon NO";
            this.TelefonNO.Width = 149;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.DisplayIndex = 2;
            this.KullaniciAdi.Text = "Kullanıcı Adı";
            this.KullaniciAdi.Width = 134;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Yetki";
            this.columnHeader4.Width = 88;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(284, 470);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(149, 35);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(69, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yetki";
            // 
            // tbxŞifre
            // 
            this.tbxŞifre.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxŞifre.Location = new System.Drawing.Point(148, 411);
            this.tbxŞifre.Multiline = true;
            this.tbxŞifre.Name = "tbxŞifre";
            this.tbxŞifre.Size = new System.Drawing.Size(285, 35);
            this.tbxŞifre.TabIndex = 11;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEmail.Location = new System.Drawing.Point(148, 362);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(285, 35);
            this.tbxEmail.TabIndex = 10;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(148, 313);
            this.tbxKullaniciAdi.Multiline = true;
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(285, 35);
            this.tbxKullaniciAdi.TabIndex = 9;
            // 
            // tbxTelNo
            // 
            this.tbxTelNo.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTelNo.Location = new System.Drawing.Point(148, 264);
            this.tbxTelNo.Multiline = true;
            this.tbxTelNo.Name = "tbxTelNo";
            this.tbxTelNo.Size = new System.Drawing.Size(285, 35);
            this.tbxTelNo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(61, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(25, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefon NO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxAdSoyad.Location = new System.Drawing.Point(148, 215);
            this.tbxAdSoyad.Multiline = true;
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(285, 35);
            this.tbxAdSoyad.TabIndex = 1;
            // 
            // cbxYetki
            // 
            this.cbxYetki.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYetki.FormattingEnabled = true;
            this.cbxYetki.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı",
            "Personel"});
            this.cbxYetki.Location = new System.Drawing.Point(148, 170);
            this.cbxYetki.Name = "cbxYetki";
            this.cbxYetki.Size = new System.Drawing.Size(285, 31);
            this.cbxYetki.TabIndex = 0;
            this.cbxYetki.Text = "Seçim Yapınız.";
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPersonel";
            this.Text = "Güvenlik ve Erişim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxYetki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAdSoyad;
        private System.Windows.Forms.TextBox tbxŞifre;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.TextBox tbxTelNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListView listKullanicilar;
        private System.Windows.Forms.ColumnHeader AdiSoyadi;
        private System.Windows.Forms.ColumnHeader TelefonNO;
        private System.Windows.Forms.ColumnHeader KullaniciAdi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxYetkiListesi;
        private System.Windows.Forms.ColumnHeader KullaniciID;
        private System.Windows.Forms.TextBox tbxKullaniciID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDuzenle;
    }
}