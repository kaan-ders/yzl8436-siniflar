using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Seans
    {
        public int SeansNo;
        public int Saat;
        public string Gun;
        public Salon Salon;
        public Film Film;

        public ArrayList Biletler = new ArrayList(); //Bilet class'ından nesneler

        public Seans(int no, int saat, string gun, Salon salon, Film film)
        {
            SeansNo = no;
            Saat = saat;
            Gun = gun;
            Salon = salon;
            Film = film;
        }
    }

    public class Salon
    {
        public int No;
        public int Kapasite;
    }

    public class Film
    {
        public string Adi;
    }

    public class Bilet
    {
        public string No;
        public int Adet;
        public decimal Fiyat;
    }
}
