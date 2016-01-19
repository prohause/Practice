using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class Diamonds
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write("*");
                for (int h = 1; h < (n / 2 - i); h++)
                {
                    Console.Write("-");
                }
                for (int h = 0; h < 2 * i + 1; h++)
                {
                    Console.Write("@");
                }
                for (int h = 1; h < (n / 2 - i); h++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (int i = (int)n / 2 - 2; i >= 0; i--)
            {
                Console.Write("*");
                for (int h = 1; h < (n / 2 - i); h++)
                {
                    Console.Write("-");
                }
                for (int h = 0; h < 2 * i + 1; h++)
                {
                    Console.Write("@");
                }
                for (int h = 1; h < (n / 2 - i); h++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
