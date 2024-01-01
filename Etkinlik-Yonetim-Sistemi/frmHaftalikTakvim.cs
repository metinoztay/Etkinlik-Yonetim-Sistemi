using Etkinlik_Yonetim_Sistemi.CellMerge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Collections;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmHaftalikTakvim : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        string sorgu;
        public Button haftalikButon;
        public List<string> kategoriListesi = new List<string>();
        Hashtable renkAnahtari = new Hashtable(); 
        public DateTime tarih;
        string[] gunler = new string[] { "Pazar","Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"};
        public frmHaftalikTakvim()
        {
            InitializeComponent();
        }

        private void frmAylikTakvim_Load(object sender, EventArgs e)
        {
            int baslangic = (int)tarih.DayOfWeek;

            for (int i = 0; i < 7; i++)
            {
                DataGridViewTextBoxColumn baslik = new DataGridViewTextBoxColumn();
                
                baslik.HeaderText = gunler[(baslangic + i+4)%7];
                baslik.Name = gunler[(baslangic + i+4) % 7];
                baslik.ReadOnly = true;
                baslik.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHaftalik.Columns.Add(baslik);
            }

            for (int i = 9; i <= 23; i++)
            {
                    if (i==9)
                    {
                        dgvHaftalik.Rows.Add("0"+i.ToString()+":00");
                    }
                    else
                    {
                        dgvHaftalik.Rows.Add(i.ToString() + ":00");
                    }                    
            }
            RenkleriEkle();
            EtkinlikGuncelle();            
        }

        private void RenkleriEkle()
        {
            renkAnahtari.Add("Düğün", Color.Orange);
            renkAnahtari.Add("Sünnet Düğünü", Color.Blue);
            renkAnahtari.Add("Toplantı", Color.Green);
            renkAnahtari.Add("Kına", Color.Red);
            renkAnahtari.Add("Nişan", Color.Yellow);
            renkAnahtari.Add("Nikâh", Color.Purple);
            renkAnahtari.Add("İftar", Color.Brown);
            renkAnahtari.Add("Kokteyl", Color.Pink);
            renkAnahtari.Add("Mezuniyet", Color.Cyan);
            renkAnahtari.Add("Konferans", Color.Magenta);
            renkAnahtari.Add("Diğer", Color.Gray);
        }

        private void dgvHaftalik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hucre = dgvHaftalik.SelectedCells[0];
            int satir = hucre.RowIndex;
            int sutun = hucre.ColumnIndex;
            string maxSaat="24:00";
            string minSaat="08:00";
            string seciliSaat = "00:00";
            DateTime secilenGun = tarih.AddDays(sutun-4);

            if (hucre.Style.BackColor.Name == "0") // Arkaplan beyaz ise
            {

                for (int i = satir; i < 14; i++)
                {
                    if (dgvHaftalik[sutun, i].Style.BackColor.Name != "0")
                    {
                        maxSaat = dgvHaftalik[0, i].Value.ToString();
                        break;
                    }
                }

                for (int i = satir; i > 0 ; i--)
                {
                    if (dgvHaftalik[sutun, i].Style.BackColor.Name != "0")
                    {
                        minSaat = dgvHaftalik[0, i].Value.ToString();
                        break;
                    }
                }

                seciliSaat = dgvHaftalik[0, satir].Value.ToString();


                frmEtkinlikYönet etkinlikDetay = new frmEtkinlikYönet();
                etkinlikDetay.SozlesmeFormuOlustur(secilenGun,minSaat,maxSaat,seciliSaat);
                etkinlikDetay.ShowDialog();
                EtkinlikGuncelle();
                haftalikButon.PerformClick();
            }
            else
            {
                frmEtkinlikGoruntule etkinlikGoruntule = new frmEtkinlikGoruntule((int)dgvHaftalik[sutun, satir].Value);
                etkinlikGoruntule.ShowDialog();
                EtkinlikGuncelle();
                haftalikButon.PerformClick();
            }            
        }


        public void EtkinlikGuncelle()
        {
            DateTime tabloBaslangicGunu = tarih.AddDays(-3);
            DateTime tabloBitisGunu = tarih.AddDays(+3);
            DateTime sutunGun;

            for (int i = 0; i <= 6; i++)
            {
                sutunGun = tabloBaslangicGunu.AddDays(i);
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    baglanti.Open();
                    sorgu = $"SELECT * FROM tblEtkinlikler WHERE EtkinlikTarihi = @etkinlikTarihi";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {

                        komut.Parameters.AddWithValue("@etkinlikTarihi", sutunGun.ToShortDateString());
                        using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                        {
                            while (dataOkuyucu.Read())
                            {
                                string EtkinlikTarihi = (string)dataOkuyucu["EtkinlikTarihi"];
                                string nitelik = (string)dataOkuyucu["Niteligi"];                                
                                int baslangicIndex = int.Parse(dataOkuyucu["BaslamaSaati"].ToString().Substring(0, 2)) - 9;
                                int bitisIndex = int.Parse(dataOkuyucu["BitisSaati"].ToString().Substring(0, 2)) - 10;
                                int sozlesmeID = (int)dataOkuyucu["SozlesmeID"];

                                if (!kategoriListesi.Contains(nitelik))
                                {
                                    continue;
                                }
                                for (int j = baslangicIndex; j <= bitisIndex; j++)
                                {
                                    dgvHaftalik[i+1, j].Style.BackColor = (Color)renkAnahtari[nitelik];
                                    dgvHaftalik[i + 1, j].Value = sozlesmeID;
                                }
                            }
                        }
                    }
                }
            }            
        }

    }
}
