using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmMusteriIslemleriOnay : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        string SQLIslemi;
        public frmMusteriIslemleriOnay()
        {
            InitializeComponent();
        }

        Musteri musteriBilgileri = new Musteri();
        public frmMusteriIslemleriOnay(Musteri m, string SQLIslemi)
        {
            InitializeComponent();
            musteriBilgileri = m;
            lblAdSoyad.Text += m.adiSoyadi;
            lblEmail.Text += m.email;
            lblTelefonNo.Text += m.telefonNumarasi;
            lblAdres.Text += m.adres;
            this.SQLIslemi = SQLIslemi;

            switch (SQLIslemi)
            {
                case "GUNCELLE":
                    lblOnaySorusu.Text = "Müşteri bilgileri yukarıda verilen şekilde güncellenecektir.\nOnaylıyor musunuz?"; break;
                case "EKLE":
                    lblOnaySorusu.Text = "Müşteri bilgileri yukarıda verilen şekilde eklenecektir.\nOnaylıyor musunuz?"; break;
                case "SIL":
                    lblOnaySorusu.Text = "Yukarıda bilgileri verilen müşteri silinecektir.\nOnaylıyor musunuz?"; 
                    SilinecekMusteriGoster(m.musteriID);
                    break;
                default:
                    break;
            }

        }
        private void btnOnay_Click(object sender, EventArgs e)
        {
            switch (SQLIslemi)
            {
                case "GUNCELLE":
                    Guncelle(musteriBilgileri); break;
                case "EKLE":
                    Ekle(musteriBilgileri); break;
                case "SIL":
                    Sil(musteriBilgileri); break;
                default:
                    break;
            }

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guncelle(Musteri m)
        {

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE tblMusteriler SET TelefonNumarasi = @YeniTelefonNO," +
                        "AdiSoyadi = @YeniAdiSoyadi,Adres = @YeniAdres," +
                        "Email = @YeniEposta WHERE MusteriID = @MusteriID";


                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@YeniEposta", m.email);
                        komut.Parameters.AddWithValue("@MusteriID", m.musteriID);
                        komut.Parameters.AddWithValue("@YeniTelefonNO", m.telefonNumarasi);
                        komut.Parameters.AddWithValue("@YeniAdres", m.adres);
                        komut.Parameters.AddWithValue("@YeniAdiSoyadi", m.adiSoyadi);


                        int degisenSatirSayisi = komut.ExecuteNonQuery();


                        if (degisenSatirSayisi > 0)
                        {
                            MessageBox.Show("Müşteri bilgileri güncellendi!");
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
        private void Ekle(Musteri m)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblMusteriler (AdiSoyadi, Email,TelefonNumarasi, Adres) VALUES (@AdiSoyadi, @Email,@TelefonNO, @Adres)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Email", m.email);
                        komut.Parameters.AddWithValue("@TelefonNO", m.telefonNumarasi);
                        komut.Parameters.AddWithValue("@Adres", m.adres);
                        komut.Parameters.AddWithValue("@AdiSoyadi", m.adiSoyadi);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show($"Yeni müşteri eklendi!");
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
        private void Sil(Musteri m)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "DELETE FROM tblMusteriler WHERE MusteriID = @MusteriID";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@MusteriID", m.musteriID);

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Müşteri silindi!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Silme başarısız! Belirtilen müşteri bulunamadı.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void SilinecekMusteriGoster(int id)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT * FROM tblMusteriler WHERE MusteriID = @MusteriID";

                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@MusteriID", id);
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            lblAdSoyad.Text = "Ad Soyad:    " + dataOkuyucu["AdiSoyadi"];
                            lblEmail.Text = "Email:    " + dataOkuyucu["Email"];
                            lblTelefonNo.Text = "Telefon Numarası:     " + dataOkuyucu["TelefonNumarasi"];
                            lblAdres.Text = "Şifre:    " + dataOkuyucu["Adres"];
                        }
                    }
                }
            }
        }

    }
}

