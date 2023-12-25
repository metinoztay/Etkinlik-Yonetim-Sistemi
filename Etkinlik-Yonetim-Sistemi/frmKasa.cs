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
    public partial class frmKasa : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";

        public frmKasa()
        {
            InitializeComponent();
        }

        private void btnTahsilatEkle_Click(object sender, EventArgs e)
        {
            frmOdemeAl odemeAl = new frmOdemeAl();
            if (tbxTCNo.Text.Trim() != string.Empty )
            {
                odemeAl.TCNo = tbxTCNo.Text;
            }
            odemeAl.ShowDialog();
            btnBul.PerformClick();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listKasaGecmisi.Items.Clear();
            string secim = cbxFiltre.SelectedItem.ToString();
            List<string> musteriTClistesi = MusteriIDListesiOlustur();

            foreach (var musteri in musteriTClistesi)
            {
                string adSoyad=" ";
                string TcNo = " ";
                int toplam = 0;
                int odenen = 0;
                int kalan = 0;
                string sorgu;

                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    sorgu = $"SELECT * FROM tblKasa WHERE TCNo = @tcNo";


                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {

                        komut.Parameters.AddWithValue("@tcNo", musteri);


                        using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                        {
                            string[] musteriGecmis;
                            while (dataOkuyucu.Read())
                            {
                                int tutar = (int)dataOkuyucu["Tutar"];
                                string tur = (string)dataOkuyucu["Tur"];
                                adSoyad = (string)dataOkuyucu["AdSoyad"];
                                TcNo = (string )dataOkuyucu["TCNo"];
                                if (tur == "Sözleşme")
                                {
                                    toplam += tutar;
                                }
                                else if (tur == "Ödeme")
                                {
                                    odenen += tutar;
                                }

                                kalan = toplam - odenen;
                            }

                            string durum;
                            if (kalan <= 0)
                            {
                                durum = "TAMAMLANDI";
                            }
                            else
                            {
                                durum = "TAMAMLANMADI";
                            }

                            if (toplam != 0)
                            {
                                if (secim == "TAMAMLANAN" && durum == "TAMAMLANDI")
                                {
                                    musteriGecmis = new string[] { TcNo, adSoyad, toplam.ToString(), odenen.ToString(), durum};
                                    listKasaGecmisi.Items.Add(new ListViewItem(musteriGecmis));
                                }
                                else if (secim == "TAMAMLANMAYAN" && durum == "TAMAMLANMADI")
                                {
                                    musteriGecmis = new string[] {TcNo , adSoyad, toplam.ToString(), odenen.ToString(), durum};
                                    listKasaGecmisi.Items.Add(new ListViewItem(musteriGecmis));
                                }
                                else if (secim == "TÜMÜ")
                                {
                                    musteriGecmis = new string[] { TcNo, adSoyad, toplam.ToString(), odenen.ToString(), durum , TcNo };
                                    listKasaGecmisi.Items.Add(new ListViewItem(musteriGecmis));
                                }                                
                            }
                        }
                    }
                }
            }


        }

        private List<string> MusteriIDListesiOlustur()
        {
            List<string> musteriTC = new List<string>();
            string sorgu;

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                sorgu = $"SELECT * FROM tblMusteriler";
                
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            musteriTC.Add((string)dataOkuyucu["TCNo"]);
                        }
                    }
                }
            }

            return musteriTC;
        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            listOdemeGecmisi.Items.Clear();
            string sorgu;
            lblKalan.Text = string.Empty;
            lblOdenen.Text = string.Empty;
            lblToplam.Text = string.Empty;

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                if (tbxTCNo.Text.Trim() != string.Empty)
                {
                    sorgu = $"SELECT * FROM tblMusteriler WHERE TCNo=@tcNo";
                }
                else
                {
                    MessageBox.Show("TC No Giriniz!");
                    return;
                }

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {

                    komut.Parameters.AddWithValue("@tcNo", tbxTCNo.Text.Trim());


                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            MusteriGecmisListele(tbxTCNo.Text.Trim());
                        }
                    }
                }
            }
        }

        private void MusteriGecmisListele(string TCNo)
        {
            int toplam = 0;
            int odenen = 0;
            listOdemeGecmisi.Items.Clear();
            string sorgu;

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                sorgu = $"SELECT * FROM tblKasa WHERE TCNo = @tcNo";


                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {

                    komut.Parameters.AddWithValue("@tcNo", TCNo);


                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            string tarih = (string)dataOkuyucu["Tarih"];
                            int tutar = (int)dataOkuyucu["Tutar"];
                            string aciklama = (string)dataOkuyucu["Aciklama"];
                            string tur = (string)dataOkuyucu["Tur"];
                            string[] musteriBilgileri = new string[] { tarih, aciklama, tur, tutar.ToString() };
                            listOdemeGecmisi.Items.Add(new ListViewItem(musteriBilgileri));
                            if (tur == "Sözleşme")
                            {
                                toplam += tutar;
                            }
                            else if (tur == "Ödeme")
                            {
                                odenen += tutar;
                            }

                            lblToplam.Text = toplam.ToString();
                            lblOdenen.Text = odenen.ToString();
                            lblKalan.Text = (toplam - odenen).ToString();
                        }
                    }
                }
            }

        }

        private void listKasaGecmisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKasaGecmisi.SelectedItems.Count != 0)
            {
                tbxTCNo.Text = listKasaGecmisi.SelectedItems[0].Text;
                btnBul.PerformClick();
            }           
        }
    }


}
