using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    public class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            return nizRiječi.Contains(tražena);
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(riječ => riječ.CompareTo(graničnaRiječ) > 0);
            throw new NotImplementedException();
        }
    }
}
