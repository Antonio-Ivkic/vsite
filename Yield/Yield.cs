﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.KontrolaToka
{
    public class Yield
    {
        static void Main(string[] args)
        {
            foreach (var kvadrat in DajKvadrate())
                Console.WriteLine(kvadrat);

            var niz1 = FibonacciList();
            foreach (var broj in niz1)
                Console.WriteLine(broj);

            var niz2 = FibonacciIEnumerable();
            foreach (var broj in niz2)
                Console.WriteLine(broj);
        }

        static IEnumerable<int> DajKvadrate()
        {
            yield return 0;
            yield return 1;
            yield return 4;
            yield return 9;
            yield return 16;
            yield return 25;
        }

        public static IList<int> FibonacciList()
        {
            List<int> rezultat = new List<int>();
            rezultat.Add(0);
            rezultat.Add(1);

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue / 2)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    rezultat.Add(trenutni);
                }
                catch (OverflowException)
                {
                    break;
                }                            
            }
            return rezultat;
        }

        public static IEnumerable<int> FibonacciIEnumerable()
        {

            yield return 0;
            yield return 1;

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue / 2)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    
                }
                catch (OverflowException)
                {
                    break;
                }
                yield return trenutni;
            }
            yield break;
        }

    }
}
