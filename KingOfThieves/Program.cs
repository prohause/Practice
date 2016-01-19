using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2 + 1; i++)
            {
                StringBuilder output = new StringBuilder();
                output.Append('-', (n / 2) + 1 - i);
                output.Append(symbol, 2 * i - 1);
                output.Append('-', (n / 2) + 1 - i);
                Console.WriteLine(output);
            }
            for (int i = n / 2; i >= 1; i--)
            {
                StringBuilder output = new StringBuilder();
                output.Append('-', (n / 2) + 1 - i);
                output.Append(symbol, 2 * i - 1);
                output.Append('-', (n / 2) + 1 - i);
                Console.WriteLine(output);
            }

        }
    }
}
