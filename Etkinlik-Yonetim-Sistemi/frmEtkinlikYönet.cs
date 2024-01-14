using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmEtkinlikYönet : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        string kurumAdi, kurumAdresi, kurumTelefonNo, kurumWebSitesi, kurumEmail, makbuzKisiAdiSoyadi, makbuzSiraNo, makbuzTarih, makbuzTutar;
        string sozlesmeNo, etkinlikTarihi, etkinlikToplamUcret, baslamaSaati, bitisSaati, sozlesmeTarihi, musteriTCNo, musteriAdSoyad, musteriTel, musteriAdres, etkinlikNitelik, etkinlikDetay, etkinlikDavetliSayisi, etkinlikAciklama;
        public frmEtkinlikYönet()
        {
            InitializeComponent();
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
        public void SozlesmeFormuOlustur(DateTime etkinlikTarihi, string minBaslangicSaati, string maxBitisSaati, string secilisaat)
        {
            tbxEtkinlikTarihi.Text = etkinlikTarihi.ToShortDateString();

            int baslangic = int.Parse(minBaslangicSaati.Substring(0, 2))+1;
            int bitis = int.Parse(maxBitisSaati.Substring(0, 2));


            for (int i = baslangic; i <= bitis; i++)
            {
                if (i == 9)
                {
                    cbxBaslangicSaati.Items.Add("0" + i.ToString() + ":00");
                }
                else
                {
                    cbxBaslangicSaati.Items.Add(i.ToString() + ":00");
                }
            }

            cbxBaslangicSaati.SelectedItem = secilisaat;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tbxSozlesmeNo.Text.Trim() == string.Empty)
            {
                SozlesmeEkle();
            }
            else
            {
                SozlesmeGuncelle();
            }
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
                            KasaSozlesmeBilgisiEkle();
                            MusteriBilgisiEkle();
                            SozlesmeOlustur();
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

        private void MusteriBilgisiEkle()
        {

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblMusteriler (TCNo,AdiSoyadi,TelefonNumarasi,Email,Adres) VALUES (@TCNo,@AdiSoyadi,@TelefonNumarasi,@Email,@Adres)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {

                        komut.Parameters.AddWithValue("@TCNo", mtbxTCNo.Text);
                        komut.Parameters.AddWithValue("@AdiSoyadi", tbxAdiSoyadi.Text);
                        komut.Parameters.AddWithValue("@TelefonNumarasi", SadeceRakamlar(mtbxTelNo.Text));
                        komut.Parameters.AddWithValue("@Adres", tbxAdres.Text);
                        komut.Parameters.AddWithValue("@Email", " ");

                        komut.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void KasaSozlesmeBilgisiEkle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO tblKasa (TCNo,AdSoyad,Tutar,Tarih,Tur,Aciklama) VALUES (@TCNo,@AdSoyad,@Tutar,@Tarih,@Tur,@Aciklama)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@TCNo", mtbxTCNo.Text);
                        komut.Parameters.AddWithValue("@AdSoyad", tbxAdiSoyadi.Text);
                        komut.Parameters.AddWithValue("@Tutar", int.Parse(mtbxToplamUcret.Text));
                        komut.Parameters.AddWithValue("@Tarih", tbxSozlesmeTarihi.Text);
                        komut.Parameters.AddWithValue("@Tur", "Sözleşme");
                        komut.Parameters.AddWithValue("@Aciklama", tbxEtkinlikTarihi.Text + " " + cbxNitelik.SelectedItem.ToString());

                        komut.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void SozlesmeOlustur()
        {
            KurumBilgileriAl();
            SozlesmeBilgileriAl();
            string mevcutKonum = Directory.GetCurrentDirectory();
            string dosyaYolu = Path.Combine(mevcutKonum, "sozlesme.xls");
            Excel.Application excel = new Excel.Application();
            //excel.Visible = true;
            Workbook calismaKitabi;
            Worksheet calismaSayfasi;

            calismaKitabi = excel.Workbooks.Open(dosyaYolu, Editable: true);
            calismaSayfasi = calismaKitabi.Worksheets[2];

            calismaSayfasi.Cells[1, 2] = etkinlikTarihi;
            calismaSayfasi.Cells[2, 2] = baslamaSaati;
            calismaSayfasi.Cells[3, 2] = bitisSaati;
            calismaSayfasi.Cells[4, 2] = sozlesmeTarihi;
            calismaSayfasi.Cells[5, 2] = sozlesmeNo;
            calismaSayfasi.Cells[6, 2] = musteriTCNo;
            calismaSayfasi.Cells[7, 2] = musteriAdSoyad;
            calismaSayfasi.Cells[9, 2] = musteriTel;
            calismaSayfasi.Cells[10, 2] = etkinlikNitelik;
            calismaSayfasi.Cells[11, 2] = etkinlikDetay;
            calismaSayfasi.Cells[13, 2] = musteriAdres;
            calismaSayfasi.Cells[14, 2] = etkinlikDavetliSayisi;
            calismaSayfasi.Cells[15, 2] = etkinlikToplamUcret;
            calismaSayfasi.Cells[18, 2] = etkinlikAciklama;
            calismaSayfasi.Cells[20, 2] = kurumAdi;
            calismaSayfasi.Cells[23, 2] = kurumAdresi;
            calismaSayfasi.Cells[24, 2] = kurumTelefonNo;
            calismaSayfasi.Cells[25, 2] = kurumWebSitesi;
            calismaSayfasi.Cells[24, 2] = kurumEmail;

            calismaSayfasi = calismaKitabi.Worksheets[1];

            string pdfYolu = Path.Combine(mevcutKonum, "sozlesme.pdf");
            calismaSayfasi.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfYolu);

            Marshal.ReleaseComObject(calismaSayfasi);
            calismaKitabi.Close(false);
            Marshal.ReleaseComObject(calismaKitabi);
            excel.Quit();
            Marshal.ReleaseComObject(excel);

            Process.Start(pdfYolu);
        }

        private void KurumBilgileriAl()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT * FROM tblKurumBilgileri WHERE ID = @ID";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@ID", 1);
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            kurumAdi = dataOkuyucu["KurumAdi"].ToString();
                            kurumAdresi = dataOkuyucu["Adres"].ToString();
                            kurumTelefonNo = dataOkuyucu["TelefonNo"].ToString();
                            kurumWebSitesi = dataOkuyucu["WebSitesi"].ToString();
                            kurumEmail = dataOkuyucu["Email"].ToString();
                        }
                    }
                }
            }
        }

        private void SozlesmeBilgileriAl()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT TOP 1 *FROM tblEtkinlikler ORDER BY SozlesmeID DESC;";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            sozlesmeNo = dataOkuyucu["SozlesmeID"].ToString();
                            etkinlikTarihi = dataOkuyucu["EtkinlikTarihi"].ToString();
                            baslamaSaati = dataOkuyucu["BaslamaSaati"].ToString();
                            bitisSaati = dataOkuyucu["BitisSaati"].ToString();
                            sozlesmeTarihi = dataOkuyucu["SozlesmeTarihi"].ToString();
                            musteriTCNo = dataOkuyucu["TCNo"].ToString();
                            musteriAdSoyad = dataOkuyucu["AdiSoyadi"].ToString();
                            musteriTel = dataOkuyucu["TelefonNumarasi"].ToString();
                            musteriAdres = dataOkuyucu["Adresi"].ToString();
                            etkinlikNitelik = dataOkuyucu["Niteligi"].ToString();
                            etkinlikDetay = dataOkuyucu["Detay"].ToString();
                            etkinlikDavetliSayisi = dataOkuyucu["DavetliSayisi"].ToString();
                            etkinlikToplamUcret = dataOkuyucu["ToplamUcret"].ToString();
                            etkinlikAciklama = dataOkuyucu["Aciklama"].ToString();
                        }
                    }
                }
            }
        }
        private void SozlesmeGuncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string updateSorgu = "UPDATE tblEtkinlikler SET EtkinlikTarihi = @EtkinlikTarihi, BaslamaSaati = @BaslamaSaati, BitisSaati = @BitisSaati, SozlesmeTarihi = @SozlesmeTarihi, TCNo = @TCNo, AdiSoyadi = @AdiSoyadi, TelefonNumarasi = @TelefonNumarasi, Adresi = @Adresi, Niteligi = @Niteligi, Detay = @Detay, DavetliSayisi = @DavetliSayisi, ToplamUcret = @ToplamUcret, Aciklama = @Aciklama WHERE SozlesmeID = @SozlesmeID";
                    using (SqlCommand komut = new SqlCommand(updateSorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@EtkinlikTarihi", tbxEtkinlikTarihi.Text);
                        komut.Parameters.AddWithValue("@BaslamaSaati", cbxBaslangicSaati.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@BitisSaati", cbxBitisSaati.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@SozlesmeTarihi", tbxSozlesmeTarihi.Text);
                        komut.Parameters.AddWithValue("@TCNo", mtbxTCNo.Text);
                        komut.Parameters.AddWithValue("@AdiSoyadi", tbxAdiSoyadi.Text);
                        komut.Parameters.AddWithValue("@TelefonNumarasi", SadeceRakamlar(mtbxTelNo.Text));
                        komut.Parameters.AddWithValue("@Adresi", tbxAdres.Text);
                        komut.Parameters.AddWithValue("@Niteligi", cbxNitelik.SelectedItem.ToString());
                        komut.Parameters.AddWithValue("@Detay", tbxDetay.Text.Trim());
                        komut.Parameters.AddWithValue("@DavetliSayisi", int.Parse(mtbxDavetliSayisi.Text));
                        komut.Parameters.AddWithValue("@ToplamUcret", int.Parse(mtbxToplamUcret.Text));
                        komut.Parameters.AddWithValue("@Aciklama", tbxAciklama.Text.Trim());
                        komut.Parameters.AddWithValue("@SozlesmeID", tbxSozlesmeNo.Text.Trim());

                        int etkilenenSatirSayisi = komut.ExecuteNonQuery();

                        if (etkilenenSatirSayisi > 0)
                        {
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
                            cbxNitelik.SelectedItem = (string)dataOkuyucu["Niteligi"];
                            tbxSozlesmeTarihi.Text = DateTime.Now.ToShortDateString();
                            mtbxTCNo.Text = (string)dataOkuyucu["TCNo"];
                            tbxAdiSoyadi.Text = (string)dataOkuyucu["AdiSoyadi"];
                            mtbxTelNo.Text = (string)dataOkuyucu["TelefonNumarasi"];
                            tbxAdres.Text = (string)dataOkuyucu["Adresi"];
                            tbxDetay.Text = (string)dataOkuyucu["Detay"];
                            mtbxDavetliSayisi.Text = dataOkuyucu["DavetliSayisi"].ToString();
                            mtbxToplamUcret.Text = dataOkuyucu["ToplamUcret"].ToString();
                            tbxAciklama.Text = (string)dataOkuyucu["Aciklama"];
                        }
                    }
                }
            }
        }
        private string SadeceRakamlar(string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (!tbxSozlesmeNo.Enabled)
            {
                mtbxTCNo.Enabled = false;
                tbxAdiSoyadi.Enabled = false;
                mtbxTelNo.Enabled = false;
                tbxAdres.Enabled = false;
                cbxNitelik.Enabled = false;
                tbxDetay.Enabled = false;
                mtbxDavetliSayisi.Enabled = false;
                mtbxToplamUcret.Enabled = false;
                tbxAciklama.Enabled = false;
                tbxSozlesmeNo.Enabled = true;
            }
            else
            {
                SozlesmeFormuYukle(int.Parse(tbxSozlesmeNo.Text.Trim()));
                btnSil.Visible = true;
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            frmOdemeAl odemeAl = new frmOdemeAl();
            odemeAl.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
