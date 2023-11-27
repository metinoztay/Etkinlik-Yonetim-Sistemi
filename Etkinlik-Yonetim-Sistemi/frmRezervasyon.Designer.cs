namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmRezervasyon
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
            this.btnEtkinlikEkle = new System.Windows.Forms.Button();
            this.panelTakvimArkaplan = new System.Windows.Forms.Panel();
            this.panelTakvim = new System.Windows.Forms.Panel();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.mcalGunSecici = new System.Windows.Forms.MonthCalendar();
            this.panelTakvimArkaplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Location = new System.Drawing.Point(850, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 436);
            this.panel1.TabIndex = 1;
            // 
            // btnEtkinlikEkle
            // 
            this.btnEtkinlikEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEtkinlikEkle.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEtkinlikEkle.FlatAppearance.BorderSize = 0;
            this.btnEtkinlikEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtkinlikEkle.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEtkinlikEkle.Location = new System.Drawing.Point(719, 3);
            this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
            this.btnEtkinlikEkle.Size = new System.Drawing.Size(105, 33);
            this.btnEtkinlikEkle.TabIndex = 3;
            this.btnEtkinlikEkle.Text = "Etkinlik Ekle";
            this.btnEtkinlikEkle.UseVisualStyleBackColor = false;
            this.btnEtkinlikEkle.Click += new System.EventHandler(this.btnEtkinlikEkle_Click);
            // 
            // panelTakvimArkaplan
            // 
            this.panelTakvimArkaplan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTakvimArkaplan.BackColor = System.Drawing.Color.LightYellow;
            this.panelTakvimArkaplan.Controls.Add(this.panelTakvim);
            this.panelTakvimArkaplan.Controls.Add(this.btnEtkinlikEkle);
            this.panelTakvimArkaplan.Controls.Add(this.btnAylik);
            this.panelTakvimArkaplan.Controls.Add(this.btnHaftalik);
            this.panelTakvimArkaplan.Controls.Add(this.btnGunluk);
            this.panelTakvimArkaplan.Location = new System.Drawing.Point(12, 12);
            this.panelTakvimArkaplan.Name = "panelTakvimArkaplan";
            this.panelTakvimArkaplan.Size = new System.Drawing.Size(827, 657);
            this.panelTakvimArkaplan.TabIndex = 2;
            // 
            // panelTakvim
            // 
            this.panelTakvim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTakvim.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTakvim.Location = new System.Drawing.Point(3, 38);
            this.panelTakvim.Name = "panelTakvim";
            this.panelTakvim.Size = new System.Drawing.Size(821, 616);
            this.panelTakvim.TabIndex = 4;
            // 
            // btnAylik
            // 
            this.btnAylik.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAylik.FlatAppearance.BorderSize = 0;
            this.btnAylik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAylik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylik.Location = new System.Drawing.Point(151, 3);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(74, 33);
            this.btnAylik.TabIndex = 2;
            this.btnAylik.Text = "Aylık";
            this.btnAylik.UseVisualStyleBackColor = false;
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHaftalik.FlatAppearance.BorderSize = 0;
            this.btnHaftalik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaftalik.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaftalik.Location = new System.Drawing.Point(77, 3);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(74, 33);
            this.btnHaftalik.TabIndex = 1;
            this.btnHaftalik.Text = "Haftalık";
            this.btnHaftalik.UseVisualStyleBackColor = false;
            // 
            // btnGunluk
            // 
            this.btnGunluk.BackColor = System.Drawing.Color.Gainsboro;
            this.btnGunluk.FlatAppearance.BorderSize = 0;
            this.btnGunluk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGunluk.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(3, 3);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(74, 33);
            this.btnGunluk.TabIndex = 0;
            this.btnGunluk.Text = "Günlük";
            this.btnGunluk.UseVisualStyleBackColor = false;
            // 
            // mcalGunSecici
            // 
            this.mcalGunSecici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcalGunSecici.BackColor = System.Drawing.Color.LightYellow;
            this.mcalGunSecici.Location = new System.Drawing.Point(851, 12);
            this.mcalGunSecici.Name = "mcalGunSecici";
            this.mcalGunSecici.TabIndex = 3;
            this.mcalGunSecici.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcalGunSecici_DateChanged);
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.mcalGunSecici);
            this.Controls.Add(this.panelTakvimArkaplan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyon";
            this.Text = "Rezervasyon";
            this.panelTakvimArkaplan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEtkinlikEkle;
        private System.Windows.Forms.Panel panelTakvimArkaplan;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnHaftalik;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.Panel panelTakvim;
        private System.Windows.Forms.MonthCalendar mcalGunSecici;
    }
}