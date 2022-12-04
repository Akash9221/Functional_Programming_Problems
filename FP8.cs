using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP8_EvenOdd
    {
        public static void Even_Odd()
        {
            //Accept Two Values From User
            Console.WriteLine("Enter The First Value");
            int Num1 = Convert.ToInt32(Console.ReadLine());

            //Logic For Check Number Is Even Or Odd
            if (Num1 % 2 == 0)
            {
                Console.WriteLine("The Given Is Even Number");
            }
            else
            {
                Console.WriteLine("The Given Number Is Odd Number");
            }
        }
    }
}
