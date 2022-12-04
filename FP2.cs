using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP2_LeapYear
    {
        public static void Leap_Year()
        {
            //Acept Year From User
            Console.WriteLine("Enter The Year");
            int year = Convert.ToInt32(Console.ReadLine());
            //Checking Condition Of Leap Year
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("This Is A Leap Year=" + year);
            }
            else
            {
                Console.WriteLine("This Is Not A Leap Year=" + year);
            }
        }
    }
}
