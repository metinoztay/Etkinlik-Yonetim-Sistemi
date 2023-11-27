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
            int telefonNumarasi;
            string adiSoyadi= "-1";
            

            listMusteriler.Items.Clear();
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                if (tbxMusteriBul.Text.Trim() == string.Empty)
                {
                    sorgu = $"SELECT * FROM tblMusteriler";
                }
                else if (int.TryParse(tbxMusteriBul.Text.Trim(), out telefonNumarasi))
                {
                    sorgu = $"SELECT * FROM tblMusteriler WHERE TelefonNumarasi= @arananKelime";
                }
                else
                {
                    sorgu = $"SELECT * FROM tblMusteriler WHERE AdiSoyadi LIKE @arananKelime";
                }

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@arananKelime", "%" + tbxMusteriBul.Text.Trim() + "%");
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
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.adiSoyadi = tbxAdSoyad.Text.Trim();
            musteri.email = tbxEmail.Text.Trim();
            musteri.telefonNumarasi = tbxTelNo.Text.Trim();
            musteri.adres = tbxAdres.Text;

            string[] bilgiler = new string[] { musteri.adiSoyadi, musteri.telefonNumarasi, musteri.adres};

            foreach (string bilgi in bilgiler)
            {
                if (bilgi == String.Empty)
                {
                    MessageBox.Show("Lütfen gerekli bilgileri doldurunuz!");
                    return;
                }
            }


            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblMusteriler (AdiSoyadi, Email,TelefonNumarasi, Adres) VALUES (@AdiSoyadi, @Email,@TelefonNO, @Adres)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Email", musteri.email);
                        komut.Parameters.AddWithValue("@TelefonNO", musteri.telefonNumarasi);
                        komut.Parameters.AddWithValue("@Adres", musteri.adres);
                        komut.Parameters.AddWithValue("@AdiSoyadi", musteri.adiSoyadi);

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
    }
}
