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
        bool guncellemeModu;
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
                            tbxTCNo.Text = (string)dataOkuyucu["TCNo"];
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Seçili etkinlik silinecek, onaylıyor musunuz?", "Etkinlik Sil", MessageBoxButtons.YesNo);
            if (onay.Equals(DialogResult.Yes))
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    try
                    {
                        baglanti.Open();

                        string sorgu = "DELETE FROM tblEtkinlikler WHERE SozlesmeID = @etkinlikID";

                        using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                        {
                            komut.Parameters.AddWithValue("@etkinlikID", tbxSozlesmeNo.Text.Trim());

                            int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                            if (etkilenenSatirSayisi > 0)
                            {
                                MessageBox.Show("Etkinlik silindi!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Silme başarısız! Belirtilen etkinlik bulunamadı.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            else
            {

            }

        }

        private void btnTahsilatEke_Click(object sender, EventArgs e)
        {
            frmOdemeAl odemeAl = new frmOdemeAl();
            if (tbxTCNo.Text.Trim() != string.Empty)
            {
                odemeAl.TCNo = tbxTCNo.Text;
            }
            odemeAl.ShowDialog();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            btnKaydet.Visible = true;
            mtbxTelNo.Enabled = true;
            tbxAdres.Enabled = true;
            tbxDetay.Enabled = true;
            mtbxDavetliSayisi.Enabled = true;
            mtbxToplamUcret.Enabled = true;
            tbxAciklama.Enabled = true;
            guncellemeModu = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (guncellemeModu)
            {
                SozlesmeGuncelle();
            }
        }

        
        private void SozlesmeGuncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string updateSorgu = "UPDATE tblEtkinlikler SET TelefonNumarasi = @TelefonNumarasi, Adresi = @Adresi, Detay = @Detay, DavetliSayisi = @DavetliSayisi, ToplamUcret = @ToplamUcret, Aciklama = @Aciklama WHERE SozlesmeID = @SozlesmeID";
                    using (SqlCommand komut = new SqlCommand(updateSorgu, baglanti))
                    {
                        
                        komut.Parameters.AddWithValue("@TelefonNumarasi", SadeceRakamlar(mtbxTelNo.Text));
                        komut.Parameters.AddWithValue("@Adresi", tbxAdres.Text);
                        komut.Parameters.AddWithValue("@Detay", tbxDetay.Text.Trim());
                        komut.Parameters.AddWithValue("@DavetliSayisi", int.Parse(mtbxDavetliSayisi.Text));
                        komut.Parameters.AddWithValue("@ToplamUcret", int.Parse(mtbxToplamUcret.Text));
                        komut.Parameters.AddWithValue("@Aciklama", tbxAciklama.Text.Trim());
                        komut.Parameters.AddWithValue("@SozlesmeID", tbxSozlesmeNo.Text.Trim());

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
                            KasaBilgileriGuncelle();                            
                            MessageBox.Show($"Sözleşme güncellendi!");
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


        private void KasaBilgileriGuncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string updateSorgu = "UPDATE tblKasa SET Tutar = @tutar, Aciklama = @aciklama WHERE TCNo = @TCNo AND Tur = @tur AND Tarih = @sozlesmeTarihi";
                    using (SqlCommand komut = new SqlCommand(updateSorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Tutar", int.Parse(mtbxToplamUcret.Text));
                        komut.Parameters.AddWithValue("@Aciklama", tbxEtkinlikTarihi.Text + " " + tbxNiteligi.Text + " / " + DateTime.Now.ToShortDateString() + " tarihinde güncellendi.");
                        komut.Parameters.AddWithValue("@TCNo", tbxTCNo.Text);
                        komut.Parameters.AddWithValue("@tur", "Sözleşme");
                        komut.Parameters.AddWithValue("@sozlesmeTarihi", tbxSozlesmeTarihi.Text);

                        komut.ExecuteNonQuery();
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
