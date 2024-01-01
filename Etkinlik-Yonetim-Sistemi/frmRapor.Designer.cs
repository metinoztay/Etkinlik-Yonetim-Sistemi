namespace Etkinlik_Yonetim_Sistemi
{
    partial class frmRapor
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartEtkinlikDağilimi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbxYillar = new System.Windows.Forms.ComboBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.chartEtkinlikSayilari = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikDağilimi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikSayilari)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartEtkinlikDağilimi);
            this.panel1.Controls.Add(this.cbxYillar);
            this.panel1.Controls.Add(this.btnGetir);
            this.panel1.Controls.Add(this.chartEtkinlikSayilari);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 657);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Yıl Seçimi :";
            // 
            // chartEtkinlikDağilimi
            // 
            this.chartEtkinlikDağilimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartEtkinlikDağilimi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEtkinlikDağilimi.Legends.Add(legend1);
            this.chartEtkinlikDağilimi.Location = new System.Drawing.Point(650, 121);
            this.chartEtkinlikDağilimi.Name = "chartEtkinlikDağilimi";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Etkinlikler";
            this.chartEtkinlikDağilimi.Series.Add(series1);
            this.chartEtkinlikDağilimi.Size = new System.Drawing.Size(424, 521);
            this.chartEtkinlikDağilimi.TabIndex = 6;
            this.chartEtkinlikDağilimi.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Türlerine Göre Yıllık Etkinlik Dağılımı";
            this.chartEtkinlikDağilimi.Titles.Add(title1);
            // 
            // cbxYillar
            // 
            this.cbxYillar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxYillar.FormattingEnabled = true;
            this.cbxYillar.Items.AddRange(new object[] {
            "2024",
            "2023"});
            this.cbxYillar.Location = new System.Drawing.Point(18, 58);
            this.cbxYillar.Name = "cbxYillar";
            this.cbxYillar.Size = new System.Drawing.Size(121, 28);
            this.cbxYillar.TabIndex = 5;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(156, 57);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(88, 30);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // chartEtkinlikSayilari
            // 
            this.chartEtkinlikSayilari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            chartArea2.Name = "ChartArea1";
            this.chartEtkinlikSayilari.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEtkinlikSayilari.Legends.Add(legend2);
            this.chartEtkinlikSayilari.Location = new System.Drawing.Point(18, 121);
            this.chartEtkinlikSayilari.Name = "chartEtkinlikSayilari";
            series2.ChartArea = "ChartArea1";
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "EtkinlikSayisi";
            this.chartEtkinlikSayilari.Series.Add(series2);
            this.chartEtkinlikSayilari.Size = new System.Drawing.Size(612, 521);
            this.chartEtkinlikSayilari.TabIndex = 3;
            this.chartEtkinlikSayilari.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Aylara Göre Etkinlik Sayıları";
            this.chartEtkinlikSayilari.Titles.Add(title2);
            // 
            // frmRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1124, 681);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRapor";
            this.Text = "frmRapor";
            this.Load += new System.EventHandler(this.frmRapor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikDağilimi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEtkinlikSayilari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEtkinlikSayilari;
        private System.Windows.Forms.ComboBox cbxYillar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEtkinlikDağilimi;
        private System.Windows.Forms.Label label1;
    }
}