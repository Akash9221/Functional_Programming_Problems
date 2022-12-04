using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    class FP5_Factor
    {
        //Finction To Print All Prime
        public static void primeFactor(int n)
        {
            while (n % 2 == 0)
            {
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                //While I Divides n Print i,n
                while (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);
        }
        public static void factors()
        {
            Console.WriteLine("Enter The NUmber");
            int n = Convert.ToInt32(Console.ReadLine());
            primeFactor(n);
        }
    }
}
