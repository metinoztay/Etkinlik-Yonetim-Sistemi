﻿namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblKullaniciGirisi = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picKullaniciAdiGirisSol = new System.Windows.Forms.PictureBox();
            this.picKullanciAdiGiris = new System.Windows.Forms.PictureBox();
            this.picSolGiris = new System.Windows.Forms.PictureBox();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullaniciAdiGirisSol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullanciAdiGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtKullaniciAdi, "txtKullaniciAdi");
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSifre_KeyDown);
            // 
            // lblKullaniciGirisi
            // 
            resources.ApplyResources(this.lblKullaniciGirisi, "lblKullaniciGirisi");
            this.lblKullaniciGirisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            this.lblKullaniciGirisi.Name = "lblKullaniciGirisi";
            // 
            // btnGiris
            // 
            resources.ApplyResources(this.btnGiris, "btnGiris");
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // picKullaniciAdiGirisSol
            // 
            this.picKullaniciAdiGirisSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(93)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.picKullaniciAdiGirisSol, "picKullaniciAdiGirisSol");
            this.picKullaniciAdiGirisSol.Name = "picKullaniciAdiGirisSol";
            this.picKullaniciAdiGirisSol.TabStop = false;
            // 
            // picKullanciAdiGiris
            // 
            this.picKullanciAdiGiris.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.picKullanciAdiGiris, "picKullanciAdiGiris");
            this.picKullanciAdiGiris.Name = "picKullanciAdiGiris";
            this.picKullanciAdiGiris.TabStop = false;
            // 
            // picSolGiris
            // 
            this.picSolGiris.Image = global::Etkinlik_Yonetim_Sistemi.Properties.Resources.Adsız_tasarım;
            resources.ApplyResources(this.picSolGiris, "picSolGiris");
            this.picSolGiris.Name = "picSolGiris";
            this.picSolGiris.TabStop = false;
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(9)))), ((int)(((byte)(44)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 22;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGiris
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblKullaniciGirisi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.picKullaniciAdiGirisSol);
            this.Controls.Add(this.picKullanciAdiGiris);
            this.Controls.Add(this.picSolGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiris";
            this.Opacity = 0.99D;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullaniciAdiGirisSol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKullanciAdiGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSolGiris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSolGiris;
        private System.Windows.Forms.PictureBox picKullanciAdiGiris;
        private System.Windows.Forms.PictureBox picKullaniciAdiGirisSol;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblKullaniciGirisi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}