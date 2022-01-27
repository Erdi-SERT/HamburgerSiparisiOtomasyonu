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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal ekstraMalzemeGeliri = 0;
            int satışAdedi = 0;
            int ÜrünAdedi = 0;
            int Sayac = 0;
            int Sayac2 = 0;
            foreach (Sipariş sipariş in Form1.TümSipariş)
            {
                ciro += sipariş.ToplamTutar; 
                foreach (Ekstra ekstraMalzeme in sipariş.EkstraMalzeme)
                {
                    ekstraMalzemeGeliri += ekstraMalzeme.Fiyatı;
                    Sayac++;
                }
                Sayac2++;
                satışAdedi += sipariş.Adet;
                lbxTümSiparişler.Items.Add(sipariş);
                
                
               
            }
            lbxTümSiparişler.Text = lbxTümSiparişler.Items.Count.ToString();
            lblCiro.Text = ciro.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString("C2");
            //lblSatılanÜrünlerinAdedi.Text = .ToString();
            lblSiparişSayısı.Text = satışAdedi.ToString();
            ÜrünAdedi = Sayac + Sayac2;
            lblSatılanÜrünlerinAdedi.Text = ÜrünAdedi.ToString();

        }
    }
}
