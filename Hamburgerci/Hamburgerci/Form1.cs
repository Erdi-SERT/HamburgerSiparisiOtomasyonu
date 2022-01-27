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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Sipariş> Siparişler = new List<Sipariş>();
        public static List<Sipariş> TümSipariş= new List<Sipariş>();
        public static List<Sipariş> MevcutSipariş= new List<Sipariş>();
        public static List<Menü> menuler = new List<Menü>()
        {
            new Menü {MenuAdı="BigKİng",Fiyati=18.25M},
            new Menü {MenuAdı="Double King Chicken",Fiyati=19.75M},
            new Menü {MenuAdı="Steakhouse",Fiyati=22.50M},
            new Menü {MenuAdı="Whooper",Fiyati=20.00M},
            new Menü {MenuAdı="Whooper JR",Fiyati=17.75M},
            new Menü {MenuAdı="Chicken Royal",Fiyati=21.25M}
        };
        public static List<Ekstra> ekstralar = new List<Ekstra>()
        {
            new Ekstra {EkstraAdi ="Ketçap",Fiyatı=0.50M},
            new Ekstra{EkstraAdi="Mayonez",Fiyatı=0.50M},
            new Ekstra{EkstraAdi="Hardal",Fiyatı=0.75M},
            new Ekstra{EkstraAdi="BBQ",Fiyatı=1.00M},
            new Ekstra{EkstraAdi="Ranch",Fiyatı=1.00M},
            new Ekstra{EkstraAdi="Buffalo",Fiyatı=1.00M}
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menü item in menuler) // 
            {
                cmbMenüler.Items.Add(item);
            }

            foreach (Ekstra item in ekstralar)
            {                                                      //tag propertyy si object tipinde tutar
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = item.EkstraAdi+item.Fiyatı, Tag=item });
                //tekrarla 
            }


            foreach (Sipariş item in MevcutSipariş)
            {
                lbxSiparişler.Items.Add(item);      // MEvcut sipariş varsa listbox a ekleyecek
            }

            rdoKüçük.Checked = true;
            cmbMenüler.SelectedIndex = 0; // -1 olursa herhangi bir şey seçili olmaz

            TutarHesapla();
          

        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparişler.Items.Count; i++)
            { 
                Sipariş gelenSipariş = (Sipariş)lbxSiparişler.Items[i];  // ıtems a alıp sipariş ile cast ettik
                toplamTutar += gelenSipariş.ToplamTutar;
                
            }
            lblToplam.Text = toplamTutar.ToString("C2");
            return toplamTutar;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Sipariş eklemek için menü seçili olması lazım 
            //Boyut seçili olması lazım
            //adet olması lazım
            //Kontrol Et methodu lazım
            Sipariş yeniSipariş = new Sipariş(); //örnek alma instance alma
                                                 
            yeniSipariş.SeciliMenü = (Menü)cmbMenüler.SelectedItem;

            if (rdoKüçük.Checked)
            {
                yeniSipariş.Boyutu = Boyut.Kucuk; 
            }
            else if (rdoOrta.Checked)
                yeniSipariş.Boyutu = Boyut.Orta;
            else if (rdoBüyük.Checked)
                yeniSipariş.Boyutu = Boyut.Buyuk;

            yeniSipariş.EkstraMalzeme = new List<Ekstra>(); //

            foreach (CheckBox flpctrl in flpEkstraMalzemeler.Controls) 
            {
                if (flpctrl.Checked) 
                {
                    yeniSipariş.EkstraMalzeme.Add((Ekstra)flpctrl.Tag);
                    //FLp kontrollerin seçilenlerin her birinin TAg property sinde tutulan malzemenin bir kopyasını verir
                }
            }

            yeniSipariş.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSipariş.Hesapla();
            TümSipariş.Add(yeniSipariş);
            MevcutSipariş.Add(yeniSipariş);
            lbxSiparişler.Items.Add(yeniSipariş);
            TutarHesapla();
            Fonksiyonlar.Temizle(this.Controls);
            //TODO: Fonksiyonlar isimli bir class oluşturunuz ve temizle isimli metot oluşturup buradaki her control temizleyiniz.
            //Menü combobox ilk eleman seçili hale gelecek boyut küçük radio seçili hale gelecek malzeme flp deki Checkbox check kaldırılacak
            //nmr 1 e hizalanacak



        }


        private void button2_Click(object sender, EventArgs e)
        {

            
            DialogResult dr = MessageBox.Show("Toplam sipariş tutarı" + TutarHesapla().ToString("C2") + "\n Satın almayı tamamalak ister misin", "Sipariş Bilgisi", MessageBoxButtons.YesNo,MessageBoxIcon.Information); 
            if (dr==DialogResult.Yes)
            {
                lbxSiparişler.Items.Clear();
                MevcutSipariş.Clear();
                TutarHesapla(); // label'daki değeri temizlemesi için
                MessageBox.Show("Siparişiniz tamamlandı");            


            }
            else
                MessageBox.Show("İptal edildi");
        }


    }
}
