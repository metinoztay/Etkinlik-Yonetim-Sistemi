namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmAylikTakvim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHaftalik = new System.Windows.Forms.DataGridView();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHaftalik
            // 
            this.dgvHaftalik.AllowUserToAddRows = false;
            this.dgvHaftalik.AllowUserToDeleteRows = false;
            this.dgvHaftalik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHaftalik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHaftalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaftalik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Saat});
            this.dgvHaftalik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHaftalik.Enabled = false;
            this.dgvHaftalik.Location = new System.Drawing.Point(0, 0);
            this.dgvHaftalik.Name = "dgvHaftalik";
            this.dgvHaftalik.ReadOnly = true;
            this.dgvHaftalik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHaftalik.RowHeadersWidth = 24;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHaftalik.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHaftalik.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvHaftalik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvHaftalik.RowTemplate.Height = 35;
            this.dgvHaftalik.Size = new System.Drawing.Size(1124, 681);
            this.dgvHaftalik.TabIndex = 0;
            this.dgvHaftalik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHaftalik_CellContentClick);
            // 
            // Saat
            // 
            this.Saat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.ReadOnly = true;
            this.Saat.Width = 64;
            // 
            // frmAylikTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.dgvHaftalik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAylikTakvim";
            this.Text = "frmAylikTakvim";
            this.Load += new System.EventHandler(this.frmAylikTakvim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvHaftalik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
    }
}