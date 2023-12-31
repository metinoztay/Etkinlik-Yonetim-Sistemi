﻿using System;
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
    public partial class frmOdemeAl : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        public string TCNo = "-1"; 
        public frmOdemeAl()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string sorgu;
            string arananKelime;

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
                            tbxAdSoyad.Text = (string)dataOkuyucu["AdiSoyadi"];
                        }
                    }
                }
            }
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOdemeAl_Load(object sender, EventArgs e)
        {
            tbxTarih.Text = DateTime.Now.ToShortDateString();
            if (TCNo != "-1")
            {
                tbxTCNo.Text = TCNo;
                btnBul.PerformClick();
            }
        }

        private void btnTahsilatEkle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblKasa (TCNo,AdSoyad,Tutar,Tarih,Tur,Aciklama) VALUES (@TCNo,@AdSoyad,@Tutar,@Tarih,@Tur,@Aciklama)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@TCNo", tbxTCNo.Text.Trim());
                        komut.Parameters.AddWithValue("@AdSoyad", tbxAdSoyad.Text);
                        komut.Parameters.AddWithValue("@Tutar", int.Parse(mtbxTutar.Text));
                        komut.Parameters.AddWithValue("@Tarih", tbxTarih.Text);
                        komut.Parameters.AddWithValue("@Tur", "Ödeme");
                        komut.Parameters.AddWithValue("@Aciklama", tbxAciklama.Text + " ");

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Tahsilat başarı ile eklendi");
                        }
                        else
                        {
                            MessageBox.Show("Tahsilat ekleme başarısız!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            this.Close();
        }
    }
}
