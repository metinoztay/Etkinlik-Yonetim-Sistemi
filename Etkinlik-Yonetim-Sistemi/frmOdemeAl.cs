using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmOdemeAl : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
        public string TCNo = "-1";
        string kurumAdi, kurumAdresi, kurumTelefonNo, kurumWebSitesi, kurumEmail, makbuzKisiAdiSoyadi, makbuzSiraNo,makbuzTarih,makbuzTutar;
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
                            MessageBox.Show("Tahsilat başarı ile eklendi.");
                            TahsilatMakbuzuOlustur();
                            MakbuzYazdir();
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

        private void TahsilatMakbuzuOlustur()
        {
            KurumBilgileriAl();
            MakbuzBilgileriAl();
            string mevcutKonum = Directory.GetCurrentDirectory();
            string dosyaYolu = Path.Combine(mevcutKonum, "TahsilatMakbuzu.xlsx");
            Excel.Application excel = new Excel.Application();
            //excel.Visible = true;
            Workbook calismaKitabi;
            Worksheet calismaSayfasi;

            calismaKitabi = excel.Workbooks.Open(dosyaYolu, Editable: true);
            calismaSayfasi = calismaKitabi.Worksheets[2];

            calismaSayfasi.Cells[1, 2] = kurumAdi;
            calismaSayfasi.Cells[2, 2] = kurumAdresi;
            calismaSayfasi.Cells[3, 2] = kurumTelefonNo;
            calismaSayfasi.Cells[4, 2] = kurumWebSitesi;
            calismaSayfasi.Cells[5, 2] = kurumEmail;
            calismaSayfasi.Cells[6, 2] = makbuzSiraNo;
            calismaSayfasi.Cells[7, 2] = makbuzTarih;
            calismaSayfasi.Cells[8, 2] = makbuzKisiAdiSoyadi;
            calismaSayfasi.Cells[9, 2] = makbuzTutar;

            calismaSayfasi = calismaKitabi.Worksheets[1];

            string pdfYolu = Path.Combine(mevcutKonum, "makbuz.pdf");
            calismaSayfasi.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, pdfYolu);

            Marshal.ReleaseComObject(calismaSayfasi);
            calismaKitabi.Close(false);
            Marshal.ReleaseComObject(calismaKitabi);
            excel.Quit();
            Marshal.ReleaseComObject(excel);
        }

        private void MakbuzYazdir()
        {            
            string mevcutKonum = Directory.GetCurrentDirectory();  
            string pdfYolu = Path.Combine(mevcutKonum, "makbuz.pdf");
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

        private void MakbuzBilgileriAl()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu;
                sorgu = $"SELECT TOP 1 *FROM tblKasa ORDER BY ID DESC;";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            makbuzSiraNo = dataOkuyucu["ID"].ToString();
                            makbuzKisiAdiSoyadi = dataOkuyucu["AdSoyad"].ToString();
                            makbuzTarih = dataOkuyucu["Tarih"].ToString();
                            makbuzTutar = dataOkuyucu["Tutar"].ToString();
                        }
                    }
                }
            }
        }


    }
}
