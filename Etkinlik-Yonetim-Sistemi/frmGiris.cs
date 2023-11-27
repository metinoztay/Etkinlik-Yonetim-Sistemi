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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;
            string kullaniciID;

            string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";
            
            string sorgu = "SELECT *FROM tblKullanicilar WHERE KullaniciAdi = @KullaniciAdi AND SifreHash = @SifreHash";
            
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@SifreHash", sifre);

                    SqlDataReader dataOkuyucu = komut.ExecuteReader();

                    if (dataOkuyucu.Read())
                    {
                        frmAnaEkran AnaEkran = new frmAnaEkran((int)dataOkuyucu["KullaniciID"]);
                        this.Hide();
                        AnaEkran.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                }
            }
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnGiris.PerformClick();
            }
        }

    }
}
