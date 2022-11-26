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

            string[] kartArray = kart2Str.Split('|');

            //kartArray[1];

            Kart kart1 = new Kart("Karo", 3);

            //kart1.Numara = 3;
            //kart1.Tip = "Karo";

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

            Salon salon2 = new Salon();
            salon2.Kapasite = 50;
            salon2.No = 2;

            Film film1 = new Film();
            film1.Adi = "Spider-man";

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

        }
    }
}