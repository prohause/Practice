using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Petar_sGame
{
    class Petar_sGame
    {
        static void Main(string[] args)
        {
            ulong start = ulong.Parse(Console.ReadLine());
            ulong end = ulong.Parse(Console.ReadLine());
            string replace = Console.ReadLine();
            BigInteger sum = 0;

            for (ulong i = start; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }
            if (sum % 2 == 0)
            {
                string newsum = Convert.ToString(sum);
                string firstChar = Convert.ToString(newsum.FirstOrDefault());
                newsum = newsum.Replace(firstChar, replace);
                Console.WriteLine(newsum);
            }
            else
            {
                string newsum = Convert.ToString(sum);
                string firstChar = Convert.ToString(newsum.LastOrDefault());
                newsum = newsum.Replace(firstChar, replace);
                Console.WriteLine(newsum);
            }
        }
    }
}
