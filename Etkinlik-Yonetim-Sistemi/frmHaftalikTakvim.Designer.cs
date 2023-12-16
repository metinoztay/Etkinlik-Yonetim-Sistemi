namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmHaftalikTakvim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHaftalik = new System.Windows.Forms.DataGridView();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHaftalik
            // 
            this.dgvHaftalik.AllowUserToAddRows = false;
            this.dgvHaftalik.AllowUserToDeleteRows = false;
            this.dgvHaftalik.AllowUserToResizeColumns = false;
            this.dgvHaftalik.AllowUserToResizeRows = false;
            this.dgvHaftalik.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHaftalik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHaftalik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHaftalik.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHaftalik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaftalik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Saat});
            this.dgvHaftalik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHaftalik.Location = new System.Drawing.Point(0, 0);
            this.dgvHaftalik.Name = "dgvHaftalik";
            this.dgvHaftalik.ReadOnly = true;
            this.dgvHaftalik.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvHaftalik.RowHeadersWidth = 24;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHaftalik.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHaftalik.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvHaftalik.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvHaftalik.RowTemplate.Height = 35;
            this.dgvHaftalik.Size = new System.Drawing.Size(1124, 681);
            this.dgvHaftalik.TabIndex = 0;
            this.dgvHaftalik.Tag = "frmHaftalikTakvim";
            this.dgvHaftalik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHaftalik_CellClick);
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
            // frmHaftalikTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.dgvHaftalik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHaftalikTakvim";
            this.Tag = "frmHaftalikTakvim";
            this.Text = "frmHaftalikTakvim";
            this.Load += new System.EventHandler(this.frmAylikTakvim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvHaftalik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
    }
}