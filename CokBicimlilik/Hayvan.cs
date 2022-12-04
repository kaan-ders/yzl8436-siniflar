using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar.CokBicimlilik
{
    public class Hayvan
    {
        public int Yas { get; set; }
        public string KupeNo { get; set; }
        public string Cins { get; set; }
        public string Cinsiyet { get; set; }

        public virtual string SesCikar()
        {
            return "Hayvanlar ses çıkartır";
        }
    }

    public class KucukBas : Hayvan
    {
        public int YunKalinligi { get; set; }
        public string YunRengi { get; set; }
    }

    public class BuyukBas : Hayvan
    {
        public int DeriKalinligi { get; set; }
        public string DeriRengi { get; set; }
    }

    public class Inek : BuyukBas
    {
        public override string SesCikar()
        {
            return "mööö";
        }
    }

    public class Koyun : KucukBas
    {
        public override string SesCikar()
        {
            return "meee";
        }
    }

    public class Keci : KucukBas
    {
        public override string SesCikar()
        {
            return "miiii";
        }
    }

    public class Manda : BuyukBas
    {
        
    }
}
