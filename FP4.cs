using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP4_HM
    {
        public static void Harmonic_Series()
        {
            int i, n;
            double s = 0.0;
            //Accept Input From User
            Console.WriteLine("Input The Number");
            n = Convert.ToInt32(Console.ReadLine());

            //Execute Harmonic Using For Loop
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/{0} +", i);
                s += 1 / (float)i;
            }
            Console.WriteLine("Sum Of A Series Upto= {1}", n, s);
        }
    }
}
