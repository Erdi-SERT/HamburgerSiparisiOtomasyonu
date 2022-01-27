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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenüEkle_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menü { MenuAdı = txtMenüAdı.Text, Fiyati = nmrMenüFiyatı.Value });
            Fonksiyonlar.Temizle(this.Controls);
            MessageBox.Show("Menü eklendi");
        }
    }
}
