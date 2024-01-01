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
    public partial class frmRapor : Form
    {
        int yil;
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";

        string[] aylar = new string[] {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Ağustos","Eylül","Ekim","Kasım","Aralık"};



        string[] etkinlikTurleri = new string[] { 
            "Düğün","Sünnet Düğünü","Toplantı","Kına","Nişan","Nikâh","İftar","Kokteyl","Mezuniyet","Konferans","Diğer" };
        int[] etkinlikSayilari = new int[11];
        
        public frmRapor()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            yil = int.Parse(cbxYillar.SelectedItem.ToString());
            EtkinlikSayilariGrafigiOlustur();
            EtkinlikDagilimiGrafigiOlustur();
        }

        private void EtkinlikDagilimiGrafigiOlustur()
        {
            
            this.chartEtkinlikDağilimi.Series["Etkinlikler"].Points.Clear();
            int sayi = 0;
            for (int i = 0; i < etkinlikTurleri.Length; i++)
            {
                sayi = EtkinlikTuruSay(yil, etkinlikTurleri[i]);
                if (sayi==0)
                {
                    continue;
                }

                this.chartEtkinlikDağilimi.Series["Etkinlikler"].Points.AddXY(etkinlikTurleri[i],sayi);
            }
        }
        private void EtkinlikSayilariGrafigiOlustur()
        {
            this.chartEtkinlikSayilari.Series["EtkinlikSayisi"].Points.Clear();
            int sayi = 0;
            for (int i = 1; i <= 12; i++)
            {
                sayi = EtkinlikSay(i, yil);
                this.chartEtkinlikSayilari.Series["EtkinlikSayisi"].Points.AddXY(aylar[i - 1], sayi);
            }
        }

        private int EtkinlikTuruSay(int yil,string etkinlikTuru)
        {
            int counter = 0;
            string sorgu;
            int index = 0;

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                sorgu = "SELECT * FROM tblEtkinlikler WHERE YEAR(CONVERT(DATETIME, EtkinlikTarihi, 104)) = @yil AND Niteligi = @etkinlikTuru";


                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@yil", yil);
                    komut.Parameters.AddWithValue("@etkinlikTuru", etkinlikTuru);

                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        private int EtkinlikSay(int ay,int yil)
        {
            int counter = 0;

            string sorgu;
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                sorgu = "SELECT * FROM tblEtkinlikler WHERE MONTH(CONVERT(DATETIME, EtkinlikTarihi, 104)) = @ay AND YEAR(CONVERT(DATETIME, EtkinlikTarihi, 104)) = @yil";


                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {

                    komut.Parameters.AddWithValue("@ay", ay);
                    komut.Parameters.AddWithValue("@yil", yil);


                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            counter++;
                        }
                    }
                }
            }
            return counter;
        }

        private void frmRapor_Load(object sender, EventArgs e)
        {
            cbxYillar.SelectedIndex = 0;
            btnGetir.PerformClick();
        }
    }
}
