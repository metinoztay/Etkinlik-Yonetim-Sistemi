using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmAylikTakvim : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        int[] etkinlikSayiSaat = new int[2];
        DateTime ilkGun;
        public MonthCalendar takvim;
        public Button haftalikButon;
        public DateTime tarih;
        public List<string> kategoriListesi = new List<string>();
        Hashtable renkler = new Hashtable();
        public frmAylikTakvim()
        {
            InitializeComponent();
        }

        private void frmAylikTakvim_Load(object sender, EventArgs e)
        {
            dgvAylik.Rows.Add();
            RenkleriEkle();

            int satir = 0;
            int sutun;
            ilkGun = new DateTime(tarih.Year, tarih.Month, 1);
            var geciciTarih = ilkGun;
            var sonGun = ilkGun.AddMonths(1).AddTicks(-1);            
            string gun = ilkGun.DayOfWeek.ToString();

            while (geciciTarih!=sonGun.AddTicks(1))
            {
                sutun = (int)geciciTarih.DayOfWeek;
                if (sutun==0)
                    sutun = 7;
                dgvAylik[sutun-1, satir].Value = "\r\n"+geciciTarih.Day.ToString();
                
                EtkinlikHesapla(geciciTarih);
                dgvAylik[sutun - 1, satir].Value += "\r\n\r\n" + etkinlikSayiSaat[1].ToString() + " saat";
                dgvAylik[sutun - 1, satir].Value += "\r\n" + etkinlikSayiSaat[0].ToString() + " etkinlik";

                if (etkinlikSayiSaat[1]<=3)
                {
                    dgvAylik[sutun - 1, satir].Style.BackColor = (Color)renkler["Boş"];
                }
                else if ( 3< etkinlikSayiSaat[1] && etkinlikSayiSaat[1] <= 6)
                {
                    dgvAylik[sutun - 1, satir].Style.BackColor = (Color)renkler["Az"];
                }
                else if (6 < etkinlikSayiSaat[1] && etkinlikSayiSaat[1] <= 9)
                {
                    dgvAylik[sutun - 1, satir].Style.BackColor = (Color)renkler["Orta"];
                }
                else if (9 < etkinlikSayiSaat[1] && etkinlikSayiSaat[1] <= 12)
                {
                    dgvAylik[sutun - 1, satir].Style.BackColor = (Color)renkler["Çok"];
                }
                else if (12 < etkinlikSayiSaat[1] && etkinlikSayiSaat[1] <= 15)
                {
                    dgvAylik[sutun - 1, satir].Style.BackColor = (Color)renkler["Dolu"];
                }

                if (sutun == 7 )
                {
                    satir++;
                    if (geciciTarih.ToShortDateString() != sonGun.ToShortDateString())
                    {
                        dgvAylik.Rows.Add();
                    }
                }

                geciciTarih = geciciTarih.AddDays(1);
            }
            
        }

        private void RenkleriEkle()
        {
            renkler.Add("Boş", Color.Green);
            renkler.Add("Az", Color.Yellow);
            renkler.Add("Orta", Color.Blue);
            renkler.Add("Çok", Color.Brown);
            renkler.Add("Dolu", Color.Red);
        }

        private void EtkinlikHesapla(DateTime gun)
        {
            etkinlikSayiSaat = new int[2]{0,0};
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = $"SELECT * FROM tblEtkinlikler WHERE EtkinlikTarihi=@etkinlikTarihi";
                

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    int baslangic=0;
                    int bitis=0;
                    string nitelik = "";
                    komut.Parameters.AddWithValue("@etkinlikTarihi", gun.ToShortDateString());
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            nitelik = (string)dataOkuyucu["Niteligi"];
                            if (!kategoriListesi.Contains(nitelik))
                            {
                                continue;
                            }
                            etkinlikSayiSaat[0]++;
                            baslangic = int.Parse(dataOkuyucu["BaslamaSaati"].ToString().Substring(0, 2));
                            bitis = int.Parse(dataOkuyucu["BitisSaati"].ToString().Substring(0, 2));
                            etkinlikSayiSaat[1] += (bitis - baslangic);
                        }
                    }
                }
            }
        }


        private void dgvAylik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var hucre = dgvAylik.SelectedCells[0];
            int satir = hucre.RowIndex;
            int sutun = hucre.ColumnIndex;
            string[] dizi = dgvAylik[sutun, satir].Value.ToString().Split('\n');
            DateTime yeniTarih = ilkGun.AddDays(int.Parse(dizi[1])-1);
            takvim.SetSelectionRange(yeniTarih, yeniTarih);
            haftalikButon.PerformClick();                       
        }
        
    }
}
