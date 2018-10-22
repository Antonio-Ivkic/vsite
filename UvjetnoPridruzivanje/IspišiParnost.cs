using System;

namespace Vsite.CSharp.KontrolaToka
{
    public static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            // TODO:041 Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti 
            // broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // TODO:042 Korištenjem grananja if dodijeliti varijabli odgovor vrijednost 
            // "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }
    }
}
