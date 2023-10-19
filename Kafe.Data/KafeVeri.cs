using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe.Data
{
    public class KafeVeri
    {
        public List<Urun> Urunler { get; set; }
        public int MasaAdet { get; set; }
        public List<Siparis> AktifSiparisler { get; set; }
        public List<Siparis> GecmisSiparisler { get; set; } 

    }
}
