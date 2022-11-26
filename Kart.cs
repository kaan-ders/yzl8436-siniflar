using System;
using System.Collections;
using System.Diagnostics.Contracts;

namespace Siniflar
{
    public class Kart
    {
        //1) özellikler -> field ve property
        //2) işlevler -> metod/fonksiyonlar

        //field
        public string Tip;
        public int Numara;
        //private int Boyut;

        //propety

        //constractor
        public Kart(string tip, int numara)
        {
            Tip = tip;
            Numara = numara;
        }

        public void KartiGoster()
        {
            //Boyut = 3;
            Console.WriteLine("Kart: " + Tip + " " + Numara);
        }
    }

    public class Deste
    {
        public ArrayList kartlar = new ArrayList();
        
        public Deste()
        {
            Doldur();
        }

        private void Doldur()
        {
            string[] kartResimleri = { "Karo", "Kupa", "Sinek", "Maça" };

            for (int i = 0; i < kartResimleri.Length; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    var kart = new Kart(kartResimleri[i], j + 1);
                    kartlar.Add(kart);
                }
            }
        }

        public void DesteyiGoster()
        {
            foreach (Kart kart in kartlar)
            {
                kart.KartiGoster();
            }
        }
    }
}