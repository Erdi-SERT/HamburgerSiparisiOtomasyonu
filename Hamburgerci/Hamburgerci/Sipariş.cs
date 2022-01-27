using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
    public class Sipariş
    {
        public Menü SeciliMenü{ get; set; } // Menü adına eşitlememiz lazım
        public decimal ToplamTutar{ get; set; }  // 
        public Boyut Boyutu{ get; set; }
        public List<Ekstra> EkstraMalzeme{ get; set; }
        public int Adet{ get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenü.Fiyati;
            switch (Boyutu)
            {
                case Boyut.Kucuk:
                    break;
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.1M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
                default:
                    break;
            }
            foreach (Ekstra ekstra in EkstraMalzeme)
            {
                ToplamTutar += ekstra.Fiyatı;   // list olduğu için foreach ile döndük
            }
            ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {
            // Nesne adı ile çağrıldığında şu şekilde listbox a bastırılacak
            if (EkstraMalzeme.Count<1)
            {
                return string.Format("{0} Menü x{1} Adet,{2} Boy,{3} Toplam ", SeciliMenü.MenuAdı, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));  //C2 2 HANELİ PARA BİRİMİ CURRENT TWO
            }
            else
            {
                string ekstraMalzemeler = "";
                foreach (Ekstra ekstra in EkstraMalzeme)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');   //başında ve sonunda bulunan karakteri temizler
                return string.Format("{0} Menü x{1} Adet,{2} Boy,{3}Toplam {4}  ", SeciliMenü.MenuAdı, Adet, Boyutu.ToString(),ekstraMalzemeler, ToplamTutar.ToString("C2"));

            }
            
           
        }




    }
}
