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
    public partial class frmAylikTakvim : Form
    {
        public DateTime tarih;
        public List<string> kategoriListesi = new List<string>();
        public frmAylikTakvim()
        {
            InitializeComponent();
        }

        private void frmAylikTakvim_Load(object sender, EventArgs e)
        {
            dgvAylik.Rows.Add();

            int satir = 0;
            int sutun;
            var ilkGun = new DateTime(tarih.Year, tarih.Month, 1);
            var geciciTarih = ilkGun;
            var sonGun = ilkGun.AddMonths(1).AddTicks(-1);            
            string gun = ilkGun.DayOfWeek.ToString();

            while (geciciTarih!=sonGun.AddTicks(1))
            {
                sutun = (int)geciciTarih.DayOfWeek;
                if(sutun==0)
                    sutun = 7;
                dgvAylik[sutun-1, satir].Value = geciciTarih.Day.ToString();
                if (sutun == 7 )
                {
                    satir++;
                    if (geciciTarih.ToShortDateString() != sonGun.ToShortDateString())
                    {
                        dgvAylik.Rows.Add();
                    }
                }

                geciciTarih = geciciTarih.AddDays(1);
            }

        }
    }
}
