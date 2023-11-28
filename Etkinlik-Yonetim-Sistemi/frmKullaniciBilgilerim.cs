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
    public partial class frmKullaniciBilgilerim : Form
    {

        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        public frmKullaniciBilgilerim()
        {
            InitializeComponent();
        }

        public frmKullaniciBilgilerim(int ID)
        {
            InitializeComponent();
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT * FROM tblKullanicilar WHERE KullaniciID = @KullaniciID";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@KullaniciID", ID);
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            Kullanici kullanici = new Kullanici();
                            kullanici.kullaniciID = (int)dataOkuyucu["KullaniciID"];
                            kullanici.kullaniciAdi = (string)dataOkuyucu["KullaniciAdi"];
                            kullanici.adiSoyadi = (string)dataOkuyucu["AdiSoyadi"];
                            kullanici.email = (string)dataOkuyucu["Email"];
                            kullanici.telefonNumarasi = (string)dataOkuyucu["TelefonNumarasi"];
                            kullanici.yetki = (string)dataOkuyucu["Yetki"];
                            kullanici.sifre = (string)dataOkuyucu["SifreHash"];

                            tbxKullaniciID.Text = kullanici.kullaniciID.ToString();
                            tbxAdSoyad.Text = kullanici.adiSoyadi;
                            tbxTelNo.Text = kullanici.telefonNumarasi;
                            tbxKullaniciAdi.Text = kullanici.kullaniciAdi;
                            tbxEmail.Text = kullanici.email;
                            tbxŞifre.Text = kullanici.sifre;
                            cbxYetki.SelectedItem = kullanici.yetki;
                        }
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Kullanici guncelKullaniciBilgileri = new Kullanici();
            guncelKullaniciBilgileri.adiSoyadi = tbxAdSoyad.Text.Trim();
            guncelKullaniciBilgileri.kullaniciAdi = tbxKullaniciAdi.Text.Trim();
            guncelKullaniciBilgileri.sifre = tbxŞifre.Text.Trim();
            guncelKullaniciBilgileri.email = tbxEmail.Text.Trim();
            guncelKullaniciBilgileri.telefonNumarasi = SadeceRakamlar(tbxTelNo.Text.Trim());
            guncelKullaniciBilgileri.kullaniciID = (tbxKullaniciID.Text == string.Empty) ? 0 : Convert.ToInt32(tbxKullaniciID.Text);
            if (guncelKullaniciBilgileri.kullaniciID == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!");
                return;
            }
            else
            {
                guncelKullaniciBilgileri.yetki = cbxYetki.SelectedItem.ToString();
            }

            if (cbxYetki.SelectedItem != null)
            {
                guncelKullaniciBilgileri.yetki = cbxYetki.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcının yetkisini seçiniz!");
                return;
            }





            string[] bilgiler = new string[] { guncelKullaniciBilgileri.adiSoyadi, guncelKullaniciBilgileri.kullaniciAdi,
            guncelKullaniciBilgileri.sifre,guncelKullaniciBilgileri.email,guncelKullaniciBilgileri.telefonNumarasi,guncelKullaniciBilgileri.yetki};

            foreach (string bilgi in bilgiler)
            {
                if (bilgi == String.Empty)
                {
                    MessageBox.Show("Lütfen tüm bilgileri doldurunuz!");
                    return;
                }
            }

            frmKullanıcıIslemleriOnay onay = new frmKullanıcıIslemleriOnay(guncelKullaniciBilgileri, "GUNCELLE");
            onay.ShowDialog();
        }
        private string SadeceRakamlar(string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }
    }
}
