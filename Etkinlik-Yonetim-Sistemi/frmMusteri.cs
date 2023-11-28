using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmMusteri : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            string sorgu;
            int arananKelime;            

            listMusteriler.Items.Clear();
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                if (tbxMusteriBul.Text.Trim() == string.Empty)
                {
                    sorgu = $"SELECT * FROM tblMusteriler";
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(tbxMusteriBul.Text.Trim(), "[^0-9]"))
                {
                    sorgu = $"SELECT * FROM tblMusteriler WHERE TelefonNumarasi= @arananKelime";
                }
                else
                {
                    sorgu = $"SELECT * FROM tblMusteriler WHERE AdiSoyadi LIKE @arananKelime";
                }

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(tbxMusteriBul.Text.Trim(), "[^0-9]"))
                    {

                        komut.Parameters.AddWithValue("@arananKelime", tbxMusteriBul.Text.Trim());
                    }
                    else
                    {
                        komut.Parameters.AddWithValue("@arananKelime", "%" + tbxMusteriBul.Text.Trim() + "%");
                    }
                    
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            Musteri musteri = new Musteri();
                            musteri.musteriID = (int)dataOkuyucu["MusteriID"];
                            musteri.adiSoyadi = (string)dataOkuyucu["AdiSoyadi"];
                            musteri.email = (string)dataOkuyucu["Email"];
                            musteri.telefonNumarasi = (string)dataOkuyucu["TelefonNumarasi"];
                            musteri.adres = (string)dataOkuyucu["Adres"];

                            string[] musteriBilgileri = new string[] { musteri.musteriID.ToString(),
                               musteri.adiSoyadi,musteri.telefonNumarasi};
                            listMusteriler.Items.Add(new ListViewItem(musteriBilgileri));
                        }
                    }
                }
            }

            TextBoxSifirla();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteriBilgileri = new Musteri();
            musteriBilgileri.adiSoyadi = tbxAdSoyad.Text.Trim();
            musteriBilgileri.email = tbxEmail.Text.Trim();
            musteriBilgileri.telefonNumarasi = SadeceRakamlar(tbxTelNo.Text.Trim());
            musteriBilgileri.adres = tbxAdres.Text;

            string[] bilgiler = new string[] { musteriBilgileri.adiSoyadi, musteriBilgileri.telefonNumarasi, musteriBilgileri.adres};

            foreach (string bilgi in bilgiler)
            {
                if (bilgi == String.Empty)
                {
                    MessageBox.Show("Lütfen gerekli bilgileri doldurunuz!");
                    return;
                }
            }

            frmMusteriIslemleriOnay onay = new frmMusteriIslemleriOnay(musteriBilgileri, "EKLE");
            onay.ShowDialog();

            TextBoxSifirla();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            TextBoxSifirla();
            int musteriID = Convert.ToInt32(listMusteriler.SelectedItems[0].Text);
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT * FROM tblMusteriler WHERE MusteriID = {musteriID}";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            Musteri musteri = new Musteri();
                            musteri.musteriID = (int)dataOkuyucu["MusteriID"];
                            musteri.adiSoyadi = (string)dataOkuyucu["AdiSoyadi"];
                            musteri.email = (string)dataOkuyucu["Email"];
                            musteri.telefonNumarasi = (string)dataOkuyucu["TelefonNumarasi"];
                            musteri.adres = (string)dataOkuyucu["Adres"];

                            tbxMusteriID.Text = musteri.musteriID.ToString();
                            tbxAdSoyad.Text = musteri.adiSoyadi;
                            tbxTelNo.Text = musteri.telefonNumarasi;
                            tbxEmail.Text = musteri.email;
                            tbxAdres.Text = musteri.adres;
                        }
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Musteri musteriBilgileri = new Musteri();
            musteriBilgileri.adiSoyadi = tbxAdSoyad.Text.Trim();
            musteriBilgileri.email = tbxEmail.Text.Trim();
            musteriBilgileri.telefonNumarasi = SadeceRakamlar(tbxTelNo.Text.Trim());
            musteriBilgileri.adres = tbxAdres.Text;
            musteriBilgileri.musteriID = (tbxMusteriID.Text == string.Empty) ? 0 : Convert.ToInt32(tbxMusteriID.Text);
            if (musteriBilgileri.musteriID == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }
            string[] bilgiler = new string[] { musteriBilgileri.adiSoyadi, musteriBilgileri.telefonNumarasi, musteriBilgileri.adres };

            foreach (string bilgi in bilgiler)
            {
                if (bilgi == String.Empty)
                {
                    MessageBox.Show("Lütfen gerekli bilgileri doldurunuz!");
                    return;
                }
            }

            frmMusteriIslemleriOnay onay = new frmMusteriIslemleriOnay(musteriBilgileri, "GUNCELLE");
            onay.ShowDialog();

            TextBoxSifirla();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Musteri musteriBilgileri = new Musteri(); 
            musteriBilgileri.musteriID = (tbxMusteriID.Text == string.Empty) ? 0 : Convert.ToInt32(tbxMusteriID.Text);

            if (musteriBilgileri.musteriID == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }
            frmMusteriIslemleriOnay onay = new frmMusteriIslemleriOnay(musteriBilgileri, "SIL");
            onay.ShowDialog();

            TextBoxSifirla();
        }

        private void TextBoxSifirla()
        {
            TextBox[] bilgiler = new TextBox[] { tbxAdSoyad, tbxAdres, tbxEmail, tbxMusteriBul, tbxMusteriID };

            foreach (TextBox bilgi in bilgiler)
            {
                bilgi.Text = string.Empty;
            }
            tbxTelNo.Text = string.Empty;
        }

        private string SadeceRakamlar(string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }
    }
}
