using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP6
    {
        public static void Quotient()
        {
            //Accept Divident/Divisior
            int dividend = 50, divisor = 8;

            //FInd Quotient/Remainder
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;


            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
