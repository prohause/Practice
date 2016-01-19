using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWand
{
    class MagicWand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            output.Append('.', ((3 * n + 2) / 2));
            output.Append('*');
            output.Append('.', ((3 * n + 2) / 2));
            Console.WriteLine(output);
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                output = new StringBuilder();
                output.Append('.', (((3 * n + 2) / 2) - (i)));
                output.Append('*');
                output.Append('.', 2 * i - 1);
                output.Append('*');
                output.Append('.', (((3 * n + 2) / 2) - (i)));
                Console.WriteLine(output);
            }
            output = new StringBuilder();
            output.Append('*', n);
            output.Append('.', n + 2);
            output.Append('*', n);
            Console.WriteLine(output);
            for (int i = 1; i <= n / 2; i++)
            {
                output = new StringBuilder();
                output.Append('.', i);
                output.Append('*');
                output.Append('.', (3 * n) - (2 * i));
                output.Append('*');
                output.Append('.', i);
                Console.WriteLine(output);
            }
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                output = new StringBuilder();
                output.Append('.', i);
                output.Append('*');
                output.Append('.', n / 2);
                output.Append('*');
                output.Append('.', n / 2 - (i + 1));
                output.Append('*');
                output.Append('.', n);
                output.Append('*');
                output.Append('.', n / 2 - (i + 1));
                output.Append('*');
                output.Append('.', n / 2);
                output.Append('*');
                output.Append('.', i);
                Console.WriteLine(output);
            }
            output = new StringBuilder();
            output.Append('*', n / 2 + 1);
            output.Append('.', n / 2);
            output.Append('*');
            output.Append('.', n);
            output.Append('*');
            output.Append('.', n / 2);
            output.Append('*', n / 2 + 1);
            Console.WriteLine(output);
            for (int i = 0; i < n; i++)
            {
                output = new StringBuilder();
                output.Append('.', n);
                output.Append('*');
                output.Append('.', n);
                output.Append('*');
                output.Append('.', n);
                Console.WriteLine(output);
            }
            output = new StringBuilder();
            output.Append('.', n);
            output.Append('*', n + 2);
            output.Append('.', n);
            Console.WriteLine(output);
        }
    }
}
