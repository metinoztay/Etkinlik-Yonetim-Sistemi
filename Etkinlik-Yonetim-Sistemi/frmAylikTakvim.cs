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
        string[] gunler = new string[] { "Pazar","Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"};
        public frmAylikTakvim()
        {
            InitializeComponent();
        }

        private void frmAylikTakvim_Load(object sender, EventArgs e)
        {
            int baslangic = (int)tarih.DayOfWeek;

            for (int i = 0; i < 7; i++)
            {
                DataGridViewTextBoxColumn baslik = new DataGridViewTextBoxColumn();
                baslik.HeaderText = gunler[(baslangic + i+4)%7];
                baslik.Name = gunler[(baslangic + i+4) % 7];
                baslik.ReadOnly = true;
                baslik.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvHaftalik.Columns.Add(baslik);
                
            }

            for (int i = 9; i <= 23; i++)
            {
                    if (i==9)
                    {
                        dgvHaftalik.Rows.Add("0"+i.ToString()+":00");
                    }
                    else
                    {
                        dgvHaftalik.Rows.Add(i.ToString() + ":00");
                    }                    
            }
        }

        private void dgvHaftalik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
