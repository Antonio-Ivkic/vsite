using System;

namespace Vsite.CSharp.KontrolaToka
{
    public class UsporedbeRealnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            if (JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)))
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            else
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");

            if (JednakiSu(tri * 0.1, 0.3))
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            else
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");
            if (JednakiSu(10, 1))
                Console.WriteLine("Jednaki su");
            else
                Console.WriteLine("Nisu");
            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static bool JednakiSu(double broj1, double broj2)
        {
            if(broj1==broj2)
                return true;
            double veci = Math.Abs(broj1) > Math.Abs(broj2) ? broj1 : broj2;
            return Math.Abs(broj1 - broj2) / Math.Abs(veci) < 1e-10;
        }
    }
}
