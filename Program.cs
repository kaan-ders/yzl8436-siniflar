using Siniflar.CokBicimlilik;
using Siniflar.Kalitim;
using Siniflar.StaticClass;

namespace Siniflar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int sayi;
            //1 -> ilkel veri türleri, value
            //2 -> kompleks veri türleri -> class, reference

            string kart1Str = "Karo|1|3";
            string kart2Str = "Sinek|1|8";

            kart2Str = "dsfsdfs";

            string[] kartArray = kart2Str.Split('|');

            //kartArray[1];

            Kart kart1 = new Kart("Karo", 3);
            kart1.Boyut = 50;

            kart1.SetBoyut(50); //kart1.Boyut = 50
            kart1.GetBoyut(); //kart1.Boyut

            Console.WriteLine(kart1.Boyut);

            decimal sonuc = FizikKutuphanesi.AlanHesapla(12, 40);
            decimal sonuc2 = FizikKutuphanesi.YukseklikHesapla(12);
            //FizikKutuphanesi kutuphane1 = new FizikKutuphanesi();

            FizikKutuphanesi1 kutuphane1 = new FizikKutuphanesi1();
            kutuphane1.YukseklikHesapla(23);
            kutuphane1.AlanHesapla(23, 45);

            FizikKutuphanesi1 kutuphane2 = new FizikKutuphanesi1();

            Kart krt; //-> adresi
            //stack

            //kart1.Numara = 3;
            //kart1.Tip = "Karo";

            Console.WriteLine(kart1.Sekil);
            kart1.KartiGoster();

            Kart kart2 = new Kart("Sinek", 8);

            //Kart kart3 = new Kart();
            //kart2.Numara = 8;
            //kart2.Tip = "Sinek";

            kart2.KartiGoster();

            DateTime tarih1 = new DateTime(2022, 1, 12);
            DateTime tarih2 = new DateTime(2020, 8, 3);

            //DateTime tarih3 = new DateTime()

            tarih1.AddDays(10);
            tarih2.AddYears(3);

            Deste deste = new Deste();
            //deste.Doldur();
            deste.DesteyiGoster();

            Salon salon1 = new Salon();
            salon1.Kapasite = 100;
            salon1.No = 1;

            Salon salon2 = new Salon
            {
                Kapasite = 50,
                No = 2
            };

            //salon2.Kapasite = 50;
            //salon2.No = 2;

            Film film1 = new Film
            {
                Adi = "Spider-man"
            };

            //film1.Adi = "Spider-man";

            Film film2 = new Film();
            film2.Adi = "Harry Potter";

            Film film3 = new Film();
            film3.Adi = "Yüzüklerin efendisi";

            Seans[] seanslar =
            {
                new Seans(1,12,"Perşembe", salon1, film1),
                new Seans(2, 10, "Çarşamba", salon1, film2),
                new Seans(3, 21, "Cuma", salon2, film3),
                new Seans(4, 18, "Pazartesi", salon2, film1)
            };

            //seanslar[1].Salon.Kapasite

            Kitap kitap1 = new Kitap();
            kitap1.Yazari = "Tolkien";
            kitap1.Adi = "Yüzüklerin efendisi";
            kitap1.SayfaSayisi = 500;

            Kitap kitap2 = new Kitap("Yüzüklerin efendisi", "Tolkien", 500);

            TamZamanliCalisan ahmet = new TamZamanliCalisan("Ahmet", "213123", DateTime.Now);

            UcBoyutlu salon5 = new UcBoyutlu();

            //salon5.ka

            Dikdortgen dikdortgen1 = new Dikdortgen(20, 30);
            Console.WriteLine(dikdortgen1.AlanHesapla());

            Kare kare1 = new Kare(40);
            Console.WriteLine(kare1.AlanHesapla());

            CevreYaz(dikdortgen1);
            CevreYaz(kare1);

            //
            //Sekil sekil = new Sekil();
            //sekil.AlanHesapla();

            //polymorphism
            //-----------------------------------------

            Inek inek = new Inek();
            Koyun koyun = new Koyun();
            Keci keci = new Keci();

            Manda manda = new Manda();

            SesYaz(inek);
            SesYaz(koyun);
            SesYaz(keci);

            SesYaz(manda);
        }

        static void CevreYaz(Sekil sekil)
        {
            Console.WriteLine(sekil.Cevre);
        }

        static void SesYaz(Hayvan hayvan)
        {
            Console.WriteLine(hayvan.SesCikar());
        }
    }
}