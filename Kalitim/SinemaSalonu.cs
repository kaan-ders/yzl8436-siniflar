using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.Kalitim
{
    public class Salon
    {
        public int No { get; set; }
        public int Kapasite { get; set; }

        public int KapasiteHesapla()
        {
            return 1;
        }

        //public bool KlimaVarMi { get; set; }
    }

    public class Imax : Salon
    {
        public int BakimZamani { get; set; }
    }

    public class NormalSalon : Salon
    {
        public int LambaDegisimSaati { get; set; }
    }

    public class UcBoyutlu : NormalSalon
    {
        public int GozlukSayisi { get; set; }
    }
}
