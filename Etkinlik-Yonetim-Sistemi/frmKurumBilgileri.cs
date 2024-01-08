using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmKurumBilgileri : Form
    {
        string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";

        public frmKurumBilgileri()
        {
            InitializeComponent();
        }

        private void frmKurumBilgileri_Load(object sender, EventArgs e)
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
                            tbxKurumAdi.Text = dataOkuyucu["KurumAdi"].ToString();
                            tbxAdres.Text = dataOkuyucu["Adres"].ToString();
                            tbxTelNo.Text = dataOkuyucu["TelefonNo"].ToString();
                            tbxWebSitesi.Text = dataOkuyucu["WebSitesi"].ToString();
                            tbxEmail.Text = dataOkuyucu["Email"].ToString();
                        }
                    }
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kurum bilgileri güncellenecek onaylıyor musunuz?", "Dikkat!", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.No)
                return;

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE tblKurumBilgileri SET KurumAdi = @KurumAdi," +
                        "Adres = @Adres,TelefonNo = @TelefonNo," +
                        "Email = @Email, WebSitesi = @WebSitesi WHERE ID = @ID";


                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@KurumAdi", tbxKurumAdi.Text.Trim());
                        komut.Parameters.AddWithValue("@Adres", tbxAdres.Text.TrimEnd());
                        komut.Parameters.AddWithValue("@TelefonNo", SadeceRakamlar(tbxTelNo.Text));
                        komut.Parameters.AddWithValue("@Email", tbxEmail.Text.Trim());
                        komut.Parameters.AddWithValue("@WebSitesi", tbxWebSitesi.Text.Trim());
                        komut.Parameters.AddWithValue("@ID", 1);


                        int degisenSatirSayisi = komut.ExecuteNonQuery();


                        if (degisenSatirSayisi > 0)
                        {
                            MessageBox.Show("Kurum bilgileri güncellendi!");
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


        private string SadeceRakamlar(string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }

    }
}
