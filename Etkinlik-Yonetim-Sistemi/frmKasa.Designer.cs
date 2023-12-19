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
            this.label8 = new System.Windows.Forms.Label();
            this.listMusteriler = new System.Windows.Forms.ListView();
            this.MusteriID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdiSoyadi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.listMusteriler);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 657);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Ödeme Geçmişi";
            // 
            // listMusteriler
            // 
            this.listMusteriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMusteriler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MusteriID,
            this.AdiSoyadi,
            this.TelefonNO});
            this.listMusteriler.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listMusteriler.FullRowSelect = true;
            this.listMusteriler.HideSelection = false;
            this.listMusteriler.Location = new System.Drawing.Point(24, 53);
            this.listMusteriler.Name = "listMusteriler";
            this.listMusteriler.Scrollable = false;
            this.listMusteriler.Size = new System.Drawing.Size(528, 348);
            this.listMusteriler.TabIndex = 63;
            this.listMusteriler.UseCompatibleStateImageBehavior = false;
            this.listMusteriler.View = System.Windows.Forms.View.Details;
            // 
            // MusteriID
            // 
            this.MusteriID.DisplayIndex = 2;
            this.MusteriID.Text = "";
            this.MusteriID.Width = 0;
            // 
            // AdiSoyadi
            // 
            this.AdiSoyadi.DisplayIndex = 0;
            this.AdiSoyadi.Text = "Ad Soyad";
            this.AdiSoyadi.Width = 343;
            // 
            // TelefonNO
            // 
            this.TelefonNO.DisplayIndex = 1;
            this.TelefonNO.Text = "Telefon NO";
            this.TelefonNO.Width = 167;
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(412, 15);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 35);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "LİSTELE";
            this.btnSil.UseVisualStyleBackColor = true;
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
            this.Text = "frmKasa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listMusteriler;
        private System.Windows.Forms.ColumnHeader MusteriID;
        private System.Windows.Forms.ColumnHeader AdiSoyadi;
        private System.Windows.Forms.ColumnHeader TelefonNO;
    }
}