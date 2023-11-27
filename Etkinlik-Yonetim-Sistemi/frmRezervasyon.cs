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
    public partial class frmRezervasyon : Form
    {
        private Form aktifForm;
        public frmRezervasyon()
        {
            InitializeComponent();
        }

        private void mcalGunSecici_DateChanged(object sender, DateRangeEventArgs e)
        {
            frmAylikTakvim aylikForm = new frmAylikTakvim();
            FormuYukle(aylikForm);
        }

        private void FormuYukle(Form yeniForm)
        {

            if (aktifForm != null)
            {
                aktifForm.Close();
            }
            aktifForm = yeniForm;

            yeniForm.TopLevel = false;
            yeniForm.FormBorderStyle = FormBorderStyle.None;
            yeniForm.Dock = DockStyle.Fill;
            panelTakvim.Controls.Add(yeniForm);
            panelTakvim.Tag = yeniForm;
            yeniForm.BringToFront();
            yeniForm.Show();
        }

        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
        }
    }
}
