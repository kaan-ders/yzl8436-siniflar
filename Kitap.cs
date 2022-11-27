using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public struct Kitap
    {
        public string Adi { get;set; }
        public string Yazari { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap(string adi, string yazari, int sayfa)
        {
            Adi = adi;
            Yazari = yazari;
            SayfaSayisi = sayfa;
        }
    }
}
