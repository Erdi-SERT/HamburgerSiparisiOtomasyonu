using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEKle_Click(object sender, EventArgs e)
        {
            Form1.ekstralar.Add(new Ekstra { EkstraAdi = txtEkstraMalzemeAdı.Text, Fiyatı = nmrEkstraMalzemeFiyatı.Value });
            Fonksiyonlar.Temizle(this.Controls);
            MessageBox.Show("Ekstra Malzeme eklendi");
        }


    }
}
