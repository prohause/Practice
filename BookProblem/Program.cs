using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int camp = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());

            int readDays = 30 - camp;
            if (readDays <= 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double readSpead = Math.Ceiling((double)pages / (readDays * speed));
                int years = (int)readSpead / 12;
                int months = (int)readSpead % 12;
                Console.WriteLine("{0} years {1} months", years, months);
            }
        }
    }
}
