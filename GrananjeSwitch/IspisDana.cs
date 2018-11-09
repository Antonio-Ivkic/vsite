using System;
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
               
                case (DayOfWeek.Monday):
                    return "ponedjeljak";
                case (DayOfWeek.Tuesday):
                    return "utorak";
                case (DayOfWeek.Wednesday):
                    return "Srijeda";
                case (DayOfWeek.Thursday):
                    return "cetvrtak";
                case (DayOfWeek.Friday):
                    return "petak";
                case (DayOfWeek.Saturday):
                    return "subota";
                case (DayOfWeek.Sunday):
                    return "nedjelja";
               
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:073 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case (DayOfWeek.Monday):
                case (DayOfWeek.Tuesday):
                case (DayOfWeek.Wednesday):
                case (DayOfWeek.Thursday):
                case (DayOfWeek.Friday):
                    return "radni dan";
                case (DayOfWeek.Saturday):
                case (DayOfWeek.Sunday):
                    return "vikend";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
