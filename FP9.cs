using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    internal class FP9_Vowels
    {
        public static void Vowels_Consonent()
        {
            //Accept Characters
            Console.Write("Enter Character:");
            char ch = Convert.ToChar(Console.ReadLine());

            //Checking Character
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + ":Is Vowel");
            }
            else
            {
                Console.WriteLine(ch + ":Is Consonant");
            }
        }
    }
}
