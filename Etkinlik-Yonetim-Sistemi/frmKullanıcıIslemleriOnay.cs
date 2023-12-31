﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmKullanıcıIslemleriOnay : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        string SQLIslemi;
        public frmKullanıcıIslemleriOnay()
        {
            InitializeComponent();
        }

        Kullanici k = new Kullanici();
        public frmKullanıcıIslemleriOnay(Kullanici k, string SQLIslemi)
        {
            InitializeComponent();
            this.k = k;
            lblAdSoyad.Text += k.adiSoyadi;
            lblEmail.Text += k.email;
            lblKullaniciAdi.Text += k.kullaniciAdi;
            lblTelefonNo.Text += k.telefonNumarasi;
            lblYetki.Text += k.yetki;
            lblŞifre.Text += k.sifre;
            this.SQLIslemi = SQLIslemi;

            switch (SQLIslemi)
            {
                case "GUNCELLE":
                    lblOnaySorusu.Text = "Kullanıcı bilgileri yukarıda verilen şekilde güncellenecektir.\nOnaylıyor musunuz?"; break;
                case "EKLE":
                    lblOnaySorusu.Text = "Kullanıcı bilgileri yukarıda verilen şekilde eklenecektir.\nOnaylıyor musunuz?"; break;
                case "SIL":
                    lblOnaySorusu.Text = "Yukarıda bilgileri verilen kullanıcı silinecektir.\nOnaylıyor musunuz?";
                    SilinecekKullaniciGoster(k.kullaniciID);
                    break;
                default:
                    break;
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            switch (SQLIslemi)
            {
                case "GUNCELLE":
                    Guncelle(k); break;
                case "EKLE":
                    Ekle(k); break;
                case "SIL":
                    Sil(k); break;
                default:
                    break;
            }
        }

        private void Guncelle(Kullanici k)
        {

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE tblKullanicilar SET KullaniciAdi = @YeniKullaniciAdi, " +
                        "SifreHash = @YeniSifreHash,TelefonNumarasi = @YeniTelefonNO," +
                        "AdiSoyadi = @YeniAdiSoyadi,Yetki = @YeniYetki," +
                        "Email = @YeniEposta WHERE KullaniciID = @KullaniciID";


                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {

                        komut.Parameters.AddWithValue("@YeniKullaniciAdi", k.kullaniciAdi);
                        komut.Parameters.AddWithValue("@YeniSifreHash", k.sifre);
                        komut.Parameters.AddWithValue("@YeniEposta", k.email);
                        komut.Parameters.AddWithValue("@KullaniciID", k.kullaniciID);
                        komut.Parameters.AddWithValue("@YeniTelefonNO", k.telefonNumarasi);
                        komut.Parameters.AddWithValue("@YeniYetki", k.yetki);
                        komut.Parameters.AddWithValue("@YeniAdiSoyadi", k.adiSoyadi);


                        int degisenSatirSayisi = komut.ExecuteNonQuery();


                        if (degisenSatirSayisi > 0)
                        {
                            MessageBox.Show("Kullanıcı bilgileri güncellendi!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme başarısız!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void Ekle(Kullanici k)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblKullanicilar (KullaniciAdi,AdiSoyadi, SifreHash, Email,TelefonNumarasi, Yetki) VALUES (@KullaniciAdi,@AdiSoyadi, @SifreHash, @Email,@TelefonNO, @Yetki)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@KullaniciAdi", k.kullaniciAdi);
                        komut.Parameters.AddWithValue("@SifreHash", k.sifre);
                        komut.Parameters.AddWithValue("@Email", k.email);
                        komut.Parameters.AddWithValue("@TelefonNO", k.telefonNumarasi);
                        komut.Parameters.AddWithValue("@Yetki", k.yetki);
                        komut.Parameters.AddWithValue("@AdiSoyadi", k.adiSoyadi);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show($"Yeni {this.k.yetki} eklendi!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ekleme başarısız!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void Sil(Kullanici k)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();


                    string sorgu = "DELETE FROM tblKullanicilar WHERE KullaniciID = @KullaniciID";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@KullaniciID", k.kullaniciID);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Kullanıcı silindi!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Silme başarısız! Belirtilen KullaniciID bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }

            this.Controls.Clear(); 
            this.InitializeComponent();
        }

        private void SilinecekKullaniciGoster(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT * FROM tblKullanicilar WHERE KullaniciId = @KullaniciID";
               
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@KullaniciID",id);  
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            lblAdSoyad.Text = "Ad Soyad:    " + dataOkuyucu["AdiSoyadi"];
                            lblEmail.Text = "Email:    " + dataOkuyucu["Email"];
                            lblKullaniciAdi.Text = "Kullanıcı Adı:    " + dataOkuyucu["KullaniciAdi"];
                            lblTelefonNo.Text = "Telefon Numarası:     " + dataOkuyucu["TelefonNumarasi"];
                            lblYetki.Text = "Yetki:    "+ dataOkuyucu["Yetki"];
                            lblŞifre.Text = "Şifre:    "+ dataOkuyucu["SifreHash"];                            
                        }
                    }
                }
            }
        }
    }
}
