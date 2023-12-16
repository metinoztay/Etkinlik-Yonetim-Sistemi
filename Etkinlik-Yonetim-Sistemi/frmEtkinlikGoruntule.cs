using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmEtkinlikGoruntule : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        public frmEtkinlikGoruntule(int sozlesmeID)
        {
            InitializeComponent();
            SozlesmeFormuYukle(sozlesmeID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEtkinlikDetay_Load(object sender, EventArgs e)
        {
            tbxSozlesmeTarihi.Text = DateTime.Today.ToShortDateString();
        }
        private void SozlesmeFormuYukle(int sozlesmeID)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();
                string sorgu = $"SELECT * FROM tblEtkinlikler WHERE SozlesmeID = @sozlesmeID";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {

                    komut.Parameters.AddWithValue("@sozlesmeID", sozlesmeID);
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        while (dataOkuyucu.Read())
                        {
                            tbxEtkinlikTarihi.Text = (string)dataOkuyucu["EtkinlikTarihi"];
                            tbxNiteligi.Text = (string)dataOkuyucu["Niteligi"];
                            tbxBaslangicSaati.Text = (string)dataOkuyucu["BaslamaSaati"];
                            tbxBitisSaati.Text = (string)dataOkuyucu["BitisSaati"];
                            tbxSozlesmeNo.Text = dataOkuyucu["SozlesmeID"].ToString();
                            tbxSozlesmeTarihi.Text = (string)dataOkuyucu["SozlesmeTarihi"];
                            mtbxTCNo.Text = (string)dataOkuyucu["TCNo"];
                            tbxAdiSoyadi.Text = (string)dataOkuyucu["AdiSoyadi"];
                            mtbxTelNo.Text = (string)dataOkuyucu["TelefonNumarasi"];
                            tbxAdres.Text = (string)dataOkuyucu["Adresi"];
                            tbxDetay.Text = (string)dataOkuyucu["Detay"];
                            mtbxDavetliSayisi.Text = dataOkuyucu["DavetliSayisi"].ToString()    ;
                            mtbxToplamUcret.Text = dataOkuyucu["ToplamUcret"].ToString();
                            tbxAciklama.Text = (string)dataOkuyucu["Aciklama"];
                        }
                    }
                }
            }
        }
       
    }
}
