using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP7_SwapNum
    {
        public static void SwappingNumber()
        {
            //Accept Two Value From User
            Console.WriteLine("Enter The Value For A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Value For B");
            int B = Convert.ToInt32(Console.ReadLine());
            //Logic For Swap A Two Number
            A = A * B;
            B = A / B;
            A = A / B;

            Console.Write("After swap A= " + A + "B = " + B);

        }
    }
}
