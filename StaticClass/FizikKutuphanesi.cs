using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.StaticClass
{
    public static class FizikKutuphanesi
    {
        private const decimal YerCekimiKuvveti = 9.80665M;
        public static decimal AlanHesapla(int yukseklik, int genislik)
        {
            if (yukseklik > 9.80665M)
                return 0;

            if (yukseklik > YerCekimiKuvveti)
                return 0;

            //YerCekimiKuvveti = 213123;

            return yukseklik * genislik;
        }

        public static decimal YukseklikHesapla(int alan)
        {
            return alan / 2;
        }
    }

    public class FizikKutuphanesi1
    {
        public decimal AlanHesapla(int yukseklik, int genislik)
        {
            return yukseklik * genislik;
        }

        public decimal YukseklikHesapla(int alan)
        {
            return alan / 2;
        }
    }
}
