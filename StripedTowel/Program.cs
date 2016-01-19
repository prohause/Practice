using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripedTowel
{
    class StripedTowel
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int h = 0; h < size/2 ; h++)
            {
                for (int i = 0; i < size; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                for (int i = 1; i < size + 1; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                for (int i = 2; i < size + 2; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
