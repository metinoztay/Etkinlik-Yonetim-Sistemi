using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmRezervasyon : Form
    {
        private Form aktifForm;
        List<CheckBox> kategoriler = new List<CheckBox>();
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void mcalGunSecici_DateChanged(object sender, DateRangeEventArgs e)
        {
            TakvimGuncelle();
        }

        private void FormuYukle(Form yeniForm)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            aktifForm = yeniForm;

            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            panelTakvim.Controls.Add(yeniForm);
            panelTakvim.Tag = yeniForm.Text;
            yeniForm.BringToFront();
            yeniForm.Show();
        }

        private void KategorileriEkle()
        {
            kategoriler.Clear();
            kategoriler.Add(cbxDugun);
            kategoriler.Add(cbxSunnetDugunu);
            kategoriler.Add(cbxToplanti);
            kategoriler.Add(cbxKina);
            kategoriler.Add(cbxNisan);
            kategoriler.Add(cbxNikah);
            kategoriler.Add(cbxIftar);
            kategoriler.Add(cbxKokteyl);
            kategoriler.Add(cbxMezuniyet);
            kategoriler.Add(cbxKonferans);
            kategoriler.Add(cbxDiger);
        }
        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
            frmEtkinlikYönet etkinlik = new frmEtkinlikYönet();
            etkinlik.ShowDialog();
        }
        private void btn_EtkinlikEkle_Click(object sender, EventArgs e)
        {
            frmEtkinlikYönet etkinlik = new frmEtkinlikYönet();
            etkinlik.ShowDialog();
        }

        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            KategorileriEkle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            TakvimGuncelle();
        }

        private void TakvimGuncelle()
        {
            if (panelTakvim.Tag == null)
            {
                haftalikTakvimGuncelle();
            }
            else if (panelTakvim.Tag.ToString() == "frmHaftalikTakvim")
            {
                haftalikTakvimGuncelle();
            }
            else if (panelTakvim.Tag.ToString() == "frmAylikTakvim")
            {
                aylikTakvimGuncelle();
            }
        }

        private void aylikTakvimGuncelle()
        {
            frmAylikTakvim takvim = new frmAylikTakvim();
            takvim.tarih = mcalGunSecici.SelectionRange.Start;
            takvim.takvim = mcalGunSecici;
            takvim.haftalikButon = btnHaftalik;
            foreach (var kategori in kategoriler)
            {
                if (kategori.Checked)
                {
                    takvim.kategoriListesi.Add(kategori.Text);
                }
            }
            FormuYukle(takvim);
        }
        private void haftalikTakvimGuncelle()
        {
            frmHaftalikTakvim takvim = new frmHaftalikTakvim();
            takvim.tarih = mcalGunSecici.SelectionRange.Start;
            foreach (var kategori in kategoriler)
            {
                if (kategori.Checked)
                {
                    takvim.kategoriListesi.Add(kategori.Text);
                }
            }
            FormuYukle(takvim);
        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            foreach (var kategori in kategoriler)
            {
                kategori.Checked = true;
            }
            TakvimGuncelle();
        }

        private void btnHepsiniBirak_Click(object sender, EventArgs e)
        {
            foreach (var kategori in kategoriler)
            {
                kategori.Checked = false;
            }
            TakvimGuncelle();
        }

        public void btnHaftalik_Click(object sender, EventArgs e)
        {
            haftalikTakvimGuncelle();
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            aylikTakvimGuncelle();
        }

        private void mcalGunSecici_DateSelected(object sender, DateRangeEventArgs e)
        {
            haftalikTakvimGuncelle();
        }
    }
}
