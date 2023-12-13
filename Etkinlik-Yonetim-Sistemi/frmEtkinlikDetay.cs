using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmEtkinlikDetay : Form
    {
        public frmEtkinlikDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEtkinlikDetay_Load(object sender, EventArgs e)
        {
            tbxSozlesmeTarihi.Text = DateTime.Today.ToShortDateString();
            //SozlesmeFormuOlustur(DateTime.Now, "09:00", "15:00");
        }
        private void cbxBaslangicSaati_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBitisSaati.Items.Clear();
            int baslangic = int.Parse(cbxBaslangicSaati.Text.Substring(0,2))+1;
            int bitis = int.Parse(cbxBaslangicSaati.Items[cbxBaslangicSaati.Items.Count-1].ToString().Substring(0,2));
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i == 9)
                {
                    cbxBitisSaati.Items.Add("0" + i.ToString() + ":00");
                }
                else
                {
                    cbxBitisSaati.Items.Add(i.ToString() + ":00");
                }
            }

            cbxBitisSaati.Enabled = true;
        }
        public void SozlesmeFormuOlustur(DateTime etkinlikTarihi, string minBaslangicSaati, string maxBitisSaati)
        {
            tbxEtkinlikTarihi.Text = etkinlikTarihi.ToShortDateString();

            int baslangic = int.Parse(minBaslangicSaati.Substring(0, 2));
            int bitis = int.Parse(maxBitisSaati.Substring(0, 2));


            for (int i = baslangic; i <= bitis; i++)
            {
                if (i == 9)
                {
                    cbxBaslangicSaati.Items.Add("0" + i.ToString() + ":00");
                }
                else
                {
                    cbxBaslangicSaati.Items.Add(i.ToString() + ":00");
                }
            }
        }

    }
}
