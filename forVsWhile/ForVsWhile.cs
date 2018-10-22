using System;

namespace Vsite.CSharp.KontrolaToka
{
    public class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // TODO:081 Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
        }

        public static void PetljaWhile(int n)
        {
            // TODO:082 Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // TODO:083 Prevesti program te programom ILDasm usporediti međukod gornjih metoda.

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
