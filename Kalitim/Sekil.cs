using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Kalitim
{
    public class Sekil
    {
        protected int Genislik { get; set; }
        protected int Yukseklik { get; set; }

        public int AlanHesapla()
        {
            return Genislik * Yukseklik;
        }
    }

    public class Dikdortgen : Sekil
    {
        public Dikdortgen(int genislik, int yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }
    }

    public class Kare : Sekil
    {
        public Kare(int kenar)
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }
    }
}