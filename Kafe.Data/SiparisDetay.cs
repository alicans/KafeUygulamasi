using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Data
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
        public int Adet { get; set; }
        public string TutarTL { get; private set; }
        public decimal Tutar()
        {
            return 0;
        }
    }
}
