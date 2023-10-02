using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urun_fiyat_hesaplama
{
    public partial class lblFiyat : Form
    {
        public lblFiyat()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int fiyat, miktar, tutar;

            fiyat = Convert.ToInt32(txtFiyat.Text);
            miktar = Convert.ToInt32(txtMiktar.Text);

            tutar = fiyat * miktar;
            lblTutar.Text = "tutar : " + tutar.ToString();
            

            

            







                
        }
    }
}
