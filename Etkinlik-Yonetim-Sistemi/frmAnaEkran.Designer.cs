namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaEkran));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGuvenlik = new FontAwesome.Sharp.IconButton();
            this.btnRapor = new FontAwesome.Sharp.IconButton();
            this.btnOdeme = new FontAwesome.Sharp.IconButton();
            this.btnMusteri = new FontAwesome.Sharp.IconButton();
            this.btnRezervasyon = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelKullaniciBari = new System.Windows.Forms.Panel();
            this.btnKullaniciAdiSoyadi = new FontAwesome.Sharp.IconButton();
            this.btnGizle = new FontAwesome.Sharp.IconButton();
            this.btnMaximizeMinimize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.lblAcikFormAdi = new System.Windows.Forms.Label();
            this.icoAcikFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelAcikForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelKullaniciBari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoAcikFormIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnGuvenlik);
            this.panelMenu.Controls.Add(this.btnRapor);
            this.panelMenu.Controls.Add(this.btnOdeme);
            this.panelMenu.Controls.Add(this.btnMusteri);
            this.panelMenu.Controls.Add(this.btnRezervasyon);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 756);
            this.panelMenu.TabIndex = 0;
            // 
            // btnGuvenlik
            // 
            this.btnGuvenlik.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuvenlik.FlatAppearance.BorderSize = 0;
            this.btnGuvenlik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuvenlik.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuvenlik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnGuvenlik.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnGuvenlik.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnGuvenlik.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuvenlik.IconSize = 36;
            this.btnGuvenlik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuvenlik.Location = new System.Drawing.Point(0, 380);
            this.btnGuvenlik.Name = "btnGuvenlik";
            this.btnGuvenlik.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuvenlik.Size = new System.Drawing.Size(220, 60);
            this.btnGuvenlik.TabIndex = 6;
            this.btnGuvenlik.Text = "Guvenlik";
            this.btnGuvenlik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuvenlik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuvenlik.UseVisualStyleBackColor = true;
            this.btnGuvenlik.Click += new System.EventHandler(this.btnGuvenlik_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRapor.FlatAppearance.BorderSize = 0;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnRapor.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnRapor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnRapor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRapor.IconSize = 36;
            this.btnRapor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.Location = new System.Drawing.Point(0, 320);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRapor.Size = new System.Drawing.Size(220, 60);
            this.btnRapor.TabIndex = 5;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOdeme.FlatAppearance.BorderSize = 0;
            this.btnOdeme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdeme.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdeme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnOdeme.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnOdeme.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnOdeme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOdeme.IconSize = 36;
            this.btnOdeme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdeme.Location = new System.Drawing.Point(0, 260);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOdeme.Size = new System.Drawing.Size(220, 60);
            this.btnOdeme.TabIndex = 4;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdeme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnMusteri.IconChar = FontAwesome.Sharp.IconChar.Fingerprint;
            this.btnMusteri.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnMusteri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMusteri.IconSize = 36;
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(0, 200);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMusteri.Size = new System.Drawing.Size(220, 60);
            this.btnMusteri.TabIndex = 3;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRezervasyon.FlatAppearance.BorderSize = 0;
            this.btnRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyon.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnRezervasyon.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnRezervasyon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.btnRezervasyon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRezervasyon.IconSize = 36;
            this.btnRezervasyon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervasyon.Location = new System.Drawing.Point(0, 140);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRezervasyon.Size = new System.Drawing.Size(220, 60);
            this.btnRezervasyon.TabIndex = 2;
            this.btnRezervasyon.Text = "Rezervasyon";
            this.btnRezervasyon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRezervasyon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(24, 6);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(177, 134);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelKullaniciBari
            // 
            this.panelKullaniciBari.BackColor = System.Drawing.Color.White;
            this.panelKullaniciBari.Controls.Add(this.btnKullaniciAdiSoyadi);
            this.panelKullaniciBari.Controls.Add(this.btnGizle);
            this.panelKullaniciBari.Controls.Add(this.btnMaximizeMinimize);
            this.panelKullaniciBari.Controls.Add(this.btnExit);
            this.panelKullaniciBari.Controls.Add(this.lblAcikFormAdi);
            this.panelKullaniciBari.Controls.Add(this.icoAcikFormIcon);
            this.panelKullaniciBari.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKullaniciBari.Location = new System.Drawing.Point(220, 0);
            this.panelKullaniciBari.Name = "panelKullaniciBari";
            this.panelKullaniciBari.Size = new System.Drawing.Size(1124, 75);
            this.panelKullaniciBari.TabIndex = 1;
            this.panelKullaniciBari.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelKullaniciBari_MouseDown);
            // 
            // btnKullaniciAdiSoyadi
            // 
            this.btnKullaniciAdiSoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKullaniciAdiSoyadi.FlatAppearance.BorderSize = 0;
            this.btnKullaniciAdiSoyadi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciAdiSoyadi.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciAdiSoyadi.ForeColor = System.Drawing.Color.Gray;
            this.btnKullaniciAdiSoyadi.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            this.btnKullaniciAdiSoyadi.IconColor = System.Drawing.Color.Gray;
            this.btnKullaniciAdiSoyadi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKullaniciAdiSoyadi.IconSize = 25;
            this.btnKullaniciAdiSoyadi.Location = new System.Drawing.Point(933, 41);
            this.btnKullaniciAdiSoyadi.Name = "btnKullaniciAdiSoyadi";
            this.btnKullaniciAdiSoyadi.Size = new System.Drawing.Size(191, 34);
            this.btnKullaniciAdiSoyadi.TabIndex = 5;
            this.btnKullaniciAdiSoyadi.Text = "Kullanici AdiSoyadi";
            this.btnKullaniciAdiSoyadi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKullaniciAdiSoyadi.UseVisualStyleBackColor = true;
            // 
            // btnGizle
            // 
            this.btnGizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGizle.BackColor = System.Drawing.Color.White;
            this.btnGizle.FlatAppearance.BorderSize = 0;
            this.btnGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGizle.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnGizle.IconColor = System.Drawing.Color.LightGray;
            this.btnGizle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGizle.IconSize = 22;
            this.btnGizle.Location = new System.Drawing.Point(1031, 0);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(27, 28);
            this.btnGizle.TabIndex = 4;
            this.btnGizle.UseVisualStyleBackColor = false;
            this.btnGizle.Click += new System.EventHandler(this.btnGizle_Click);
            // 
            // btnMaximizeMinimize
            // 
            this.btnMaximizeMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeMinimize.BackColor = System.Drawing.Color.White;
            this.btnMaximizeMinimize.FlatAppearance.BorderSize = 0;
            this.btnMaximizeMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeMinimize.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMaximizeMinimize.IconColor = System.Drawing.Color.LightGray;
            this.btnMaximizeMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizeMinimize.IconSize = 22;
            this.btnMaximizeMinimize.Location = new System.Drawing.Point(1064, 0);
            this.btnMaximizeMinimize.Name = "btnMaximizeMinimize";
            this.btnMaximizeMinimize.Size = new System.Drawing.Size(27, 28);
            this.btnMaximizeMinimize.TabIndex = 3;
            this.btnMaximizeMinimize.UseVisualStyleBackColor = false;
            this.btnMaximizeMinimize.Click += new System.EventHandler(this.btnMaximizeMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.LightGray;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 22;
            this.btnExit.Location = new System.Drawing.Point(1097, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAcikFormAdi
            // 
            this.lblAcikFormAdi.AutoSize = true;
            this.lblAcikFormAdi.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcikFormAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.lblAcikFormAdi.Location = new System.Drawing.Point(56, 34);
            this.lblAcikFormAdi.Name = "lblAcikFormAdi";
            this.lblAcikFormAdi.Size = new System.Drawing.Size(83, 23);
            this.lblAcikFormAdi.TabIndex = 1;
            this.lblAcikFormAdi.Text = "Ana Menü";
            // 
            // icoAcikFormIcon
            // 
            this.icoAcikFormIcon.BackColor = System.Drawing.Color.White;
            this.icoAcikFormIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.icoAcikFormIcon.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.icoAcikFormIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.icoAcikFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icoAcikFormIcon.Location = new System.Drawing.Point(18, 26);
            this.icoAcikFormIcon.Name = "icoAcikFormIcon";
            this.icoAcikFormIcon.Size = new System.Drawing.Size(32, 32);
            this.icoAcikFormIcon.TabIndex = 0;
            this.icoAcikFormIcon.TabStop = false;
            // 
            // panelAcikForm
            // 
            this.panelAcikForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAcikForm.Location = new System.Drawing.Point(226, 81);
            this.panelAcikForm.Name = "panelAcikForm";
            this.panelAcikForm.Size = new System.Drawing.Size(1112, 667);
            this.panelAcikForm.TabIndex = 2;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(1344, 756);
            this.Controls.Add(this.panelAcikForm);
            this.Controls.Add(this.panelKullaniciBari);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1254, 667);
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnaEkran";
            this.Resize += new System.EventHandler(this.frmAnaEkran_Resize);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelKullaniciBari.ResumeLayout(false);
            this.panelKullaniciBari.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoAcikFormIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnRezervasyon;
        private FontAwesome.Sharp.IconButton btnGuvenlik;
        private FontAwesome.Sharp.IconButton btnRapor;
        private FontAwesome.Sharp.IconButton btnOdeme;
        private FontAwesome.Sharp.IconButton btnMusteri;
        private System.Windows.Forms.Panel panelKullaniciBari;
        private System.Windows.Forms.Label lblAcikFormAdi;
        private FontAwesome.Sharp.IconPictureBox icoAcikFormIcon;
        private System.Windows.Forms.Panel panelAcikForm;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMaximizeMinimize;
        private FontAwesome.Sharp.IconButton btnGizle;
        private FontAwesome.Sharp.IconButton btnKullaniciAdiSoyadi;
    }
}