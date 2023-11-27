using FontAwesome.Sharp;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmAnaEkran : Form
    {
        private IconButton aktifButon;
        private Panel butonSolPanel;
        private Form aktifForm;

        public frmAnaEkran()
        {
            InitializeComponent();
            FormYuklemeIslemleri();
        }

        public frmAnaEkran(int ID)
        {
            InitializeComponent();
            FormYuklemeIslemleri();

            Kullanici aktifKullanici = new Kullanici();
            string baglantiCumlesi = "Data Source=.;Initial Catalog=dbEtkinlikYonetimSistemi;Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                string sorgu = $"SELECT * FROM tblKullanicilar WHERE KullaniciID = {ID}";
                baglanti.Open();

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    using (SqlDataReader dataOkuyucu = komut.ExecuteReader())
                    {
                        if (dataOkuyucu.Read())
                        {
                            aktifKullanici.kullaniciID = (int)dataOkuyucu["KullaniciID"];
                            aktifKullanici.kullaniciAdi = (string)dataOkuyucu["KullaniciAdi"];
                            aktifKullanici.adiSoyadi = (string)dataOkuyucu["AdiSoyadi"];
                            aktifKullanici.email = (string)dataOkuyucu["Email"];
                            aktifKullanici.telefonNumarasi = (string)dataOkuyucu["TelefonNumarasi"];
                            aktifKullanici.yetki = (string)dataOkuyucu["Yetki"];

                            if (aktifKullanici.yetki == "Yönetici")
                                btnGuvenlik.Visible = true;
                            else
                                btnGuvenlik.Visible = false;

                            btnKullaniciAdiSoyadi.Text = (string)dataOkuyucu["AdiSoyadi"];
                        }
                        else
                        {
                            // "Kullanıcı bulunamadı.";
                        }
                    }
                }
            }

        }


        private void FormYuklemeIslemleri()
        {
            butonSolPanel = new Panel();
            butonSolPanel.Size = new Size(7, 60);
            panelMenu.Controls.Add(butonSolPanel);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBRenkler
        {
            public static Color renk1 = Color.FromArgb(172, 126, 241);
            public static Color renk2 = Color.FromArgb(249, 118, 176);
            public static Color renk3 = Color.FromArgb(253, 138, 114);
            public static Color renk4 = Color.FromArgb(95, 77, 221);
            public static Color renk5 = Color.FromArgb(249, 88, 155);
            public static Color renk6 = Color.FromArgb(24, 161, 251);
        }

        private void ButonuAktifYap(object senderBtn)
        {
            if (senderBtn != null)
            {
                ButonuPasifYap();

                aktifButon = (IconButton)senderBtn;
                aktifButon.BackColor = Color.FromArgb(119,107,93);
                aktifButon.ForeColor = Color.LightYellow;
                aktifButon.TextAlign = ContentAlignment.MiddleCenter;
                aktifButon.IconColor = Color.LightYellow;
                aktifButon.TextImageRelation = TextImageRelation.TextBeforeImage;
                aktifButon.ImageAlign = ContentAlignment.MiddleRight;

                butonSolPanel.BackColor = Color.LightYellow;
                butonSolPanel.Location = new Point(0, aktifButon.Location.Y);
                butonSolPanel.Visible = true;
                butonSolPanel.BringToFront();

                icoAcikFormIcon.IconChar = aktifButon.IconChar;
                icoAcikFormIcon.IconColor = Color.LightYellow; ;
            }
        }

        private void ButonuPasifYap()
        {
            if (aktifButon != null)
            {
                aktifButon.BackColor = Color.FromArgb(243, 182, 100);
                aktifButon.ForeColor = Color.FromArgb(34, 9, 44);
                aktifButon.TextAlign = ContentAlignment.MiddleLeft;
                aktifButon.IconColor = Color.FromArgb(34, 9, 44);
                aktifButon.TextImageRelation = TextImageRelation.ImageBeforeText;
                aktifButon.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void FormuYukle(Form yeniForm)
        {
            if (panelKullanici.Visible)
            {
                panelKullanici.Visible = false;
            }

            
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            aktifForm = yeniForm;

            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            panelAcikForm.Controls.Add(yeniForm);
            panelAcikForm.Tag = yeniForm;
            yeniForm.BringToFront();
            yeniForm.Show();
            lblAcikFormAdi.Text = yeniForm.Text;
        }

        private void Reset()
        {
            ButonuPasifYap();
            butonSolPanel.Visible = false;
            icoAcikFormIcon.IconChar = IconChar.Home;
            icoAcikFormIcon.IconColor = Color.FromArgb(34, 9, 44);
            lblAcikFormAdi.Text = "Ana Menu";
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            ButonuAktifYap(sender);
            FormuYukle(new frmRezervasyon());
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            ButonuAktifYap(sender);
            FormuYukle(new frmMusteri());
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            ButonuAktifYap(sender);
            FormuYukle(new frmKasa());
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            ButonuAktifYap(sender);
            FormuYukle(new frmRapor());
        }

        private void btnGuvenlik_Click(object sender, EventArgs e)
        {
            ButonuAktifYap(sender);
            FormuYukle(new frmPersonel());
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            Reset();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelKullaniciBari_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmAnaEkran_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizeMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnMaximizeMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                btnMaximizeMinimize.IconChar = FontAwesome.Sharp.IconChar.Square;
            }


        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnKullaniciAdiSoyadi_Click(object sender, EventArgs e)
        {
            if (!panelKullanici.Visible)
            {
                panelKullanici.Visible = true;
                panelKullanici.BringToFront();
            }
            else
            {
                panelKullanici.Visible = false;
            }
        }

        private void btnKullaniciCikis_Click(object sender, EventArgs e)
        {
            frmGiris giris = new frmGiris();
            this.Hide();
            giris.ShowDialog();
        }

        private void btnKullaniciBilgilerim_Click(object sender, EventArgs e)
        {

        }

    }
}
