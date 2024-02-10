namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmKasa
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
            this.btnBul = new System.Windows.Forms.Button();
            this.tbxTCNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblOdenen = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOdemeGecmisi = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxFiltre = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listKasaGecmisi = new System.Windows.Forms.ListView();
            this.TC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdiSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTahsilatEkle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.tbxTCNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblKalan);
            this.panel1.Controls.Add(this.lblOdenen);
            this.panel1.Controls.Add(this.lblToplam);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.listOdemeGecmisi);
            this.panel1.Controls.Add(this.cbxFiltre);
            this.panel1.Controls.Add(this.btnListele);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listKasaGecmisi);
            this.panel1.Controls.Add(this.btnTahsilatEkle);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 657);
            this.panel1.TabIndex = 0;
            // 
            // btnBul
            // 
            this.btnBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBul.Location = new System.Drawing.Point(1010, 39);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(74, 35);
            this.btnBul.TabIndex = 101;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // tbxTCNo
            // 
            this.tbxTCNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxTCNo.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxTCNo.Location = new System.Drawing.Point(717, 39);
            this.tbxTCNo.Multiline = true;
            this.tbxTCNo.Name = "tbxTCNo";
            this.tbxTCNo.Size = new System.Drawing.Size(285, 35);
            this.tbxTCNo.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(645, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 99;
            this.label7.Text = "TC NO";
            // 
            // lblKalan
            // 
            this.lblKalan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(986, 572);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(80, 23);
            this.lblKalan.TabIndex = 98;
            this.lblKalan.Text = "              ";
            // 
            // lblOdenen
            // 
            this.lblOdenen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOdenen.AutoSize = true;
            this.lblOdenen.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenen.Location = new System.Drawing.Point(795, 572);
            this.lblOdenen.Name = "lblOdenen";
            this.lblOdenen.Size = new System.Drawing.Size(95, 23);
            this.lblOdenen.TabIndex = 97;
            this.lblOdenen.Text = "                 ";
            // 
            // lblToplam
            // 
            this.lblToplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(600, 572);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(75, 23);
            this.lblToplam.TabIndex = 96;
            this.lblToplam.Text = "             ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(922, 572);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 23);
            this.label10.TabIndex = 95;
            this.label10.Text = "Kalan:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(725, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 94;
            this.label9.Text = "Ödenen:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(524, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 93;
            this.label1.Text = "Toplam:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(528, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 92;
            this.label2.Text = "Geçmiş";
            // 
            // listOdemeGecmisi
            // 
            this.listOdemeGecmisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOdemeGecmisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listOdemeGecmisi.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listOdemeGecmisi.FullRowSelect = true;
            this.listOdemeGecmisi.HideSelection = false;
            this.listOdemeGecmisi.Location = new System.Drawing.Point(527, 80);
            this.listOdemeGecmisi.Name = "listOdemeGecmisi";
            this.listOdemeGecmisi.Scrollable = false;
            this.listOdemeGecmisi.Size = new System.Drawing.Size(557, 489);
            this.listOdemeGecmisi.TabIndex = 91;
            this.listOdemeGecmisi.UseCompatibleStateImageBehavior = false;
            this.listOdemeGecmisi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tarih";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.Width = 182;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tür";
            this.columnHeader6.Width = 107;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tutar";
            this.columnHeader7.Width = 180;
            // 
            // cbxFiltre
            // 
            this.cbxFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxFiltre.FormattingEnabled = true;
            this.cbxFiltre.Items.AddRange(new object[] {
            "TÜMÜ",
            "TAMAMLANAN",
            "TAMAMLANMAYAN"});
            this.cbxFiltre.Location = new System.Drawing.Point(112, 40);
            this.cbxFiltre.Name = "cbxFiltre";
            this.cbxFiltre.Size = new System.Drawing.Size(251, 30);
            this.cbxFiltre.TabIndex = 66;
            this.cbxFiltre.Text = "TÜMÜ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(369, 39);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(140, 35);
            this.btnListele.TabIndex = 65;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ödeme Listesi";
            // 
            // listKasaGecmisi
            // 
            this.listKasaGecmisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listKasaGecmisi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TC,
            this.AdiSoyadi,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listKasaGecmisi.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listKasaGecmisi.FullRowSelect = true;
            this.listKasaGecmisi.HideSelection = false;
            this.listKasaGecmisi.Location = new System.Drawing.Point(13, 80);
            this.listKasaGecmisi.MultiSelect = false;
            this.listKasaGecmisi.Name = "listKasaGecmisi";
            this.listKasaGecmisi.Scrollable = false;
            this.listKasaGecmisi.Size = new System.Drawing.Size(496, 563);
            this.listKasaGecmisi.TabIndex = 63;
            this.listKasaGecmisi.UseCompatibleStateImageBehavior = false;
            this.listKasaGecmisi.View = System.Windows.Forms.View.Details;
            this.listKasaGecmisi.SelectedIndexChanged += new System.EventHandler(this.listKasaGecmisi_SelectedIndexChanged);
            // 
            // TC
            // 
            this.TC.Text = "TC";
            this.TC.Width = 0;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.Text = "Ad Soyad";
            this.AdiSoyadi.Width = 111;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Toplam Tutar";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ödenen Tutar";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Durum";
            this.columnHeader3.Width = 141;
            // 
            // btnTahsilatEkle
            // 
            this.btnTahsilatEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTahsilatEkle.Location = new System.Drawing.Point(944, 608);
            this.btnTahsilatEkle.Name = "btnTahsilatEkle";
            this.btnTahsilatEkle.Size = new System.Drawing.Size(140, 35);
            this.btnTahsilatEkle.TabIndex = 56;
            this.btnTahsilatEkle.Text = "TAHSİLAT";
            this.btnTahsilatEkle.UseVisualStyleBackColor = true;
            this.btnTahsilatEkle.Click += new System.EventHandler(this.btnTahsilatEkle_Click);
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasa";
            this.Text = "Kasa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTahsilatEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listKasaGecmisi;
        private System.Windows.Forms.ColumnHeader AdiSoyadi;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbxFiltre;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblOdenen;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listOdemeGecmisi;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox tbxTCNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader TC;
    }
}