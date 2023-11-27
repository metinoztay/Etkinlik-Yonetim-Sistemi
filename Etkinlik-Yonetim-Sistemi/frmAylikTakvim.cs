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
        public frmAylikTakvim()
        {
            InitializeComponent();
        }

        private void frmAylikTakvim_Load(object sender, EventArgs e)
        {
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
    }
}
