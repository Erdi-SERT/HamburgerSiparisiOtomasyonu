using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public static class Fonksiyonlar
    {
        //Void değer döndürmeyecek 
        //Control tipinden Control collection 
        public static void Temizle(Control.ControlCollection koleksiyon) //static olma sebebi: Formlardan çağrıldığında ilgili controlleri tanımlıyoruz.
        {                                           //instance almadan çağırabilmek için
            //Koleksiyonların(Dizi,List gibi ) içinde controlleri dolanır

            foreach (Control item in koleksiyon)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0; 
                }
                else if (item is TextBox)
                    ((TextBox)item).Text = ""; // null, isEmpty bunlarda yazılabilir

                else if (item is RadioButton)
                {
                    RadioButton rdo = (RadioButton)item;
                    if (rdo.Name == "rdoKüçük") // Menüde büyük seçili ise onu küçüğe tanımlar
                        rdo.Checked = true;
                    else
                        rdo.Checked = false;

                }

                else if (item is NumericUpDown)
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;

                else if (item is CheckBox)
                    ((CheckBox)item).Checked = false;

                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);

                else if (item is FlowLayoutPanel)
                    Temizle(((FlowLayoutPanel)item).Controls);





            }
        }
    }
}
