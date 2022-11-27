using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Kalitim
{
    public sealed class Maas //artık maaş sınıfından yeni nesne inherit edilemez
    {
        public Maas(int calismaSaati, decimal saatlikUcret)
        {
            CalismaSaati = calismaSaati;
            SaatlikUcret = saatlikUcret;
        }

        public int CalismaSaati { get; set; }
        public decimal SaatlikUcret { get; set; }

        public decimal MaasHesapla()
        {
            return SaatlikUcret * CalismaSaati;
        }
    }

    //public class CalisanMaasi : Maas //hatalı işlem
    //{

    //}

    public class Calisan
    {
        public Calisan(string adiSoyadi, string kimlikNo, DateTime iseBaslamaTarihi)
        {
            AdiSoyadi = adiSoyadi;
            KimlikNo = kimlikNo;
            IseBaslamaTarihi = iseBaslamaTarihi;
        }

        public string AdiSoyadi { get; set; }
        public string KimlikNo { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
    }

    public class TamZamanliCalisan : Calisan
    {
        public TamZamanliCalisan(string adiSoyadi, string kimlikNo, DateTime iseBaslamaTarihi) : base(adiSoyadi, kimlikNo, iseBaslamaTarihi)
        {
            //AdiSoyadi = adiSoyadi;
            //KimlikNo = kimlikNo;
            //IseBaslamaTarihi = iseBaslamaTarihi;
        }

        public DateTime? IstenAyrilmaTarihi { get; set; }
        public decimal AylikUcret { get; set; }
    }

    public class SozlesmeliCalisan : Calisan
    {
        public SozlesmeliCalisan(string adiSoyadi, string kimlikNo, DateTime iseBaslamaTarihi) : base(adiSoyadi, kimlikNo, iseBaslamaTarihi)
        {
            //AdiSoyadi = adiSoyadi;
            //KimlikNo = kimlikNo;
            //IseBaslamaTarihi = iseBaslamaTarihi;
        }

        public DateTime SozlesmeBitisTarihi { get; set; }
        public decimal SaatlikUcret { get; set; }
        public int AylikCalismaSaati { get; set; }

        public decimal Ucret
        {
            get
            {
                return SaatlikUcret * AylikCalismaSaati;
            }
        }

    }
}
