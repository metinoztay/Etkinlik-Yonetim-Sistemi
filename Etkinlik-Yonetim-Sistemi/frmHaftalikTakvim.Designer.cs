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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHaftalik = new System.Windows.Forms.DataGridView();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHaftalik
            // 
            this.dgvHaftalik.AllowUserToAddRows = false;
            this.dgvHaftalik.AllowUserToDeleteRows = false;
            this.dgvHaftalik.AllowUserToResizeColumns = false;
            this.dgvHaftalik.AllowUserToResizeRows = false;
            this.dgvHaftalik.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHaftalik.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHaftalik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHaftalik.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
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
            this.dgvHaftalik.Size = new System.Drawing.Size(1124, 640);
            this.dgvHaftalik.TabIndex = 0;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(990, 646);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHaftalikTakvim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvHaftalik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHaftalikTakvim";
            this.Text = "frmAylikTakvim";
            this.Load += new System.EventHandler(this.frmAylikTakvim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaftalik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvHaftalik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.Button button1;
    }
}