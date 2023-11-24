using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            string connectionString = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;User ID=your_username;Password=your_password;";

            // SQL sorgusunu oluşturun (parametre kullanarak SQL Injection saldırılarından korunmak için)
            string query = "SELECT COUNT(*) FROM tbl_Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND SifreHash = @SifreHash";
        }
    }
}
