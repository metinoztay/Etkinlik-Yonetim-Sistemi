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
        private void cbxBaslangicSaati_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxBitisSaati.Items.Clear();
            int baslangic = int.Parse(cbxBaslangicSaati.Text.Substring(0,2))+1;
            int bitis = int.Parse(cbxBaslangicSaati.Items[cbxBaslangicSaati.Items.Count-1].ToString().Substring(0,2));
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i == 9)
                {
                    cbxBitisSaati.Items.Add("0" + i.ToString() + ":00");
                }
                else
                {
                    cbxBitisSaati.Items.Add(i.ToString() + ":00");
                }
            }

            cbxBitisSaati.Enabled = true;
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
                            cbxNitelik.SelectedText = (string)dataOkuyucu["Niteligi"];
                            cbxBaslangicSaati.SelectedText = (string)dataOkuyucu["BaslamaSaati"];
                            cbxBitisSaati.SelectedText = (string)dataOkuyucu["BitisSaati"];
                            tbxSozlesmeNo.Text = dataOkuyucu["SozlesmeID"].ToString();
                            tbxSozlesmeTarihi.Text = (string)dataOkuyucu["SozlesmeTarihi"];
                            mtbxTCNo.Text = (string)dataOkuyucu["TCNo"];
                            tbxAdiSoyadi.Text = (string)dataOkuyucu["AdiSoyadi"];
                            mtbxTelNo.Text = (string)dataOkuyucu["TelefonNumarasi"];
                            tbxAdres.Text = (string)dataOkuyucu["Adresi"];
                            cbxNitelik.SelectedText = (string)dataOkuyucu["Niteligi"];
                            tbxDetay.Text = (string)dataOkuyucu["Detay"];
                            mtbxDavetliSayisi.Text = dataOkuyucu["DavetliSayisi"].ToString()    ;
                            mtbxToplamUcret.Text = dataOkuyucu["ToplamUcret"].ToString();
                            tbxAciklama.Text = (string)dataOkuyucu["Aciklama"];
                        }
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SozlesmeEkle();

        }

        private void SozlesmeEkle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblEtkinlikler (EtkinlikTarihi,BaslamaSaati,BitisSaati,SozlesmeTarihi,TCNo,AdiSoyadi,TelefonNumarasi,Adresi,Niteligi,Detay,DavetliSayisi,ToplamUcret,Aciklama) VALUES (@EtkinlikTarihi,@BaslamaSaati,@BitisSaati,@SozlesmeTarihi,@TCNo,@AdiSoyadi,@TelefonNumarasi,@Adresi,@Niteligi,@Detay,@DavetliSayisi,@ToplamUcret,@Aciklama)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@EtkinlikTarihi",tbxEtkinlikTarihi.Text);
                        komut.Parameters.AddWithValue("@BaslamaSaati",cbxBaslangicSaati.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@BitisSaati",cbxBitisSaati.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@SozlesmeTarihi", tbxSozlesmeTarihi.Text);
                        komut.Parameters.AddWithValue("@TCNo",mtbxTCNo.Text);
                        komut.Parameters.AddWithValue("@AdiSoyadi",tbxAdiSoyadi.Text);
                        komut.Parameters.AddWithValue("@TelefonNumarasi",SadeceRakamlar(mtbxTelNo.Text));
                        komut.Parameters.AddWithValue("@Adresi",tbxAdres.Text);
                        komut.Parameters.AddWithValue("@Niteligi",cbxNitelik.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@Detay",tbxDetay.Text.Trim());
                        komut.Parameters.AddWithValue("@DavetliSayisi",int.Parse(mtbxDavetliSayisi.Text));
                        komut.Parameters.AddWithValue("@ToplamUcret", int.Parse(mtbxToplamUcret.Text));
                        komut.Parameters.AddWithValue("@Aciklama",tbxAciklama.Text.Trim());

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show($"Sözleşme Eklendi!");
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

        private string SadeceRakamlar(string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }
    }
}
