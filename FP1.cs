using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP1_FlipCoin
    {
        //Declare A Variable
        const int head = 1;
        const int tail = 0;
        public static void Flip_Coin()
        {
            Random random = new Random();
            int coin = random.Next(0, 2);

            //Checking If Condition
            if (coin == head)
            {
                Console.WriteLine("Head");
            }
            else
            {
                Console.WriteLine("Tail");
            }
        }
    }
}
