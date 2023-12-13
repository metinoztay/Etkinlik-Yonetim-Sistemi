using Etkinlik_Yonetim_Sistemi.CellMerge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Controls;

namespace Etkinlik_Yonetim_Sistemi
{
    public partial class frmHaftalikTakvim : Form
    {
        public DateTime tarih;
        string[] gunler = new string[] { "Pazar","Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi"};
        public frmHaftalikTakvim()
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

            dgvHaftalik[4, 0].Style.BackColor = Color.Blue;
            dgvHaftalik[4, 1].Style.BackColor = Color.Blue;
            dgvHaftalik[4, 2].Style.BackColor = Color.Blue;

            dgvHaftalik[4, 11].Style.BackColor = Color.Blue;
            dgvHaftalik[4, 12].Style.BackColor = Color.Blue;
            dgvHaftalik[4, 13].Style.BackColor = Color.Blue;
            dgvHaftalik[4, 14].Style.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*dgvHaftalik[2, 2].Value = "Deneme"; 
            var cell = (DataGridViewTextBoxCellEx)dgvHaftalik[0, 0];
            cell.ColumnSpan = 3;
            cell.RowSpan = 2;
            dgvHaftalik.Rows[1].DividerHeight = 2;*/
        }

        private void dgvHaftalik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hucre = dgvHaftalik.SelectedCells[0];
            int satir = hucre.RowIndex;
            int sutun = hucre.ColumnIndex;
            string maxSaat=" ";
            string minSaat=" ";
            DateTime secilenGun = tarih.AddDays(sutun-4);

            if (hucre.Style.BackColor.Name.ToString() == "0") // Arkaplan beyaz ise
            {

                for (int i = satir; i < 14; i++)
                {
                    if (dgvHaftalik[sutun, i].Style.BackColor == Color.Blue)
                    {
                        maxSaat = dgvHaftalik[0, i].Value.ToString();
                        break;
                    }
                }

                for (int i = satir; i > 0 ; i--)
                {
                    if (dgvHaftalik[sutun, i].Style.BackColor.Name == "0")
                    {
                        minSaat = dgvHaftalik[0, i].Value.ToString();                        
                    }
                }



                frmEtkinlikDetay etkinlikDetay = new frmEtkinlikDetay();
                etkinlikDetay.SozlesmeFormuOlustur(secilenGun,minSaat,maxSaat);
                etkinlikDetay.ShowDialog();
            }
            else
            {

            }
            
        }
    }
}
