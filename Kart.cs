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

        private string _sekil;
        public string Sekil
        {
            get { return _sekil; }
        }

        //public string Sekil { get; set; }
        private int _boyut;

        //propety
        public int Boyut
        {
            get 
            { 
                return _boyut; 
            }
            set 
            {
                if (value < 30)
                    _boyut = value;
                else
                    _boyut = 30;

                if (_boyut < 10)
                    _sekil = "kare";
                else
                    _sekil = "daire";
            }
        }

        //public int Sekil;
        //public int Sekil { get; set; }

        //private int _sekil;
        //public int Sekil 
        //{ 
        //    get { return _sekil; } 
        //    set { _sekil = value; }
        //}


        //public int Boyut
        //{
        //    get;
        //    set;
        //}

        public void SetBoyut(int deger)
        {
            if (deger < 30)
                _boyut = deger;
            else
                _boyut = 30;
        }

        public int GetBoyut()
        {
            return _boyut;
        }

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
            kartlar.Clear();
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