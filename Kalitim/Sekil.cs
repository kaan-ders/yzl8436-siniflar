using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Kalitim
{
    public abstract class Sekil
    {
        protected int Genislik { get; set; }
        protected int Yukseklik { get; set; }

        public int Cevre { get { return 123; }  }

        public abstract int AlanHesapla();

        //public virtual int AlanHesapla()
        //{
        //    return Genislik * Yukseklik;
        //}
    }

    public class Dikdortgen : Sekil
    {
        public Dikdortgen(int genislik, int yukseklik)
        {
            Genislik = genislik;
            Yukseklik = yukseklik;
        }

        public override int AlanHesapla()
        {
            return 0;
        }
    }

    public class Kare : Sekil
    {
        public Kare(int kenar)
        {
            Genislik = kenar;
            Yukseklik = kenar;
        }

        public override int AlanHesapla()
        {
            return 10;
        }
    }

    public class Daire : Sekil
    {
        public int YariCap { get; set; }

        public override int AlanHesapla()
        {
            return 20;
        }
    }

    public class Ucgen : Sekil
    {
        public int UcuncuKenar { get; set; }

        public override int AlanHesapla()
        {
            return 30;
        }
    }
}