using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunlight
{
    class Sunlight
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < ((3 * n) / 2); i++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int i = 0; i < ((3 * n) / 2); i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                StringBuilder output = new StringBuilder();
                output.Append('.', i);
                output.Append('*', 1);
                output.Append('.', (((n * 3) - (2 * i + 3)) / 2));
                output.Append('*', 1);
                output.Append('.', (((n * 3) - (2 * i + 3)) / 2));
                output.Append('*', 1);
                output.Append('.', i);
                Console.WriteLine(output);
            }
            for (int i = 1; i <= n / 2; i++)
            {
                StringBuilder output = new StringBuilder();
                output.Append('.', n);
                output.Append('*', n);
                output.Append('.', n);
                Console.WriteLine(output);
            }
            StringBuilder middle = new StringBuilder();
            middle.Append('*', 3 * n);
            Console.WriteLine(middle);
            for (int i = 1; i <= n / 2; i++)
            {
                StringBuilder output = new StringBuilder();
                output.Append('.', n);
                output.Append('*', n);
                output.Append('.', n);
                Console.WriteLine(output);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                StringBuilder output = new StringBuilder();
                output.Append('.', i);
                output.Append('*', 1);
                output.Append('.', (((n * 3) - (2 * i + 3)) / 2));
                output.Append('*', 1);
                output.Append('.', (((n * 3) - (2 * i + 3)) / 2));
                output.Append('*', 1);
                output.Append('.', i);
                Console.WriteLine(output);
            }
            for (int i = 0; i < ((3 * n) / 2); i++)
            {
                Console.Write('.');
            }
            Console.Write('*');
            for (int i = 0; i < ((3 * n) / 2); i++)
            {
                Console.Write('.');
            }
            Console.WriteLine();
        }
    }
}
