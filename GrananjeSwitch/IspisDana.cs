﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.KontrolaToka
{
    public static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:071 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.

                // TODO:072 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new NotImplementedException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:073 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"

                // TODO:074 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
