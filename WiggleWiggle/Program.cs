using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long fNumber = long.Parse(input[0]);
            long sNumber = long.Parse(input[1]);
            Console.WriteLine(fNumber);
            Console.WriteLine(sNumber);
            char[] first = Convert.ToString(fNumber, 2).PadLeft(64, '0').ToCharArray();
            char[] second = Convert.ToString(sNumber, 2).PadLeft(64, '0').ToCharArray();
            string newFirst = "";
            string newSecond = "";
            for (int i = 1; i <= first.Length; i++)
            {
                if (i % 2 == 0)
                {
                    newFirst += Convert.ToString(second[i - 1]);
                    newSecond += Convert.ToString(first[i - 1]);
                }
                else
                {
                    newFirst += Convert.ToString(first[i - 1]);
                    newSecond += Convert.ToString(second[i - 1]);
                }
            }
            Console.WriteLine(newFirst);
            Console.WriteLine(newSecond);
            Console.WriteLine(Convert.ToInt64(newFirst, 2));
            Console.WriteLine(Convert.ToInt64(newSecond, 2));
            long test = Convert.ToInt64(newFirst, 2);
            Console.WriteLine(test);
            test = ~test;
            Console.WriteLine(test);
        }
    }
}
