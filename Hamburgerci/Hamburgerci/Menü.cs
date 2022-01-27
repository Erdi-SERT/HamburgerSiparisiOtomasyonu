using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci
{
   public class Menü
    {
        public string MenuAdı{ get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString()  // nesne adıyla çağrıldıpında comboboxta menü şeklini görmek için
        {
            return MenuAdı+"Menü";
        }
    }
}
