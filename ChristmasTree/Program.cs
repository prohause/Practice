using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= (n / 2); i++)
            {
                string start = new string('\'', n - i);
                string middle = new string('^', (i + 1) * 2 - 1);
                Console.WriteLine(start + middle + start);
            }
            for (int i = 1; i <= (n / 2) + 1; i++)
            {
                string start = new string('\'', n - i);
                string middle = new string('^', (i + 1) * 2 - 1);
                Console.WriteLine(start + middle + start);
            }
            for (int i = 0; i <= (n / 2); i++)
            {
                string start = new string('\'', n - 1);
                string middle = "| |";
                Console.WriteLine(start + middle + start);
            }
            string end = new string('-', n * 2 + 1);
            Console.WriteLine(end);
        }
    }
}
