using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class Elections
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string choise = Console.ReadLine();
            if (vote <= candidates && vote > 0)
            {
                for (int i = 1; i < vote; i++)
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...", i);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");
                }
                if (choise.ToLower() == "x")
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{0:00}.|..X..|...", vote);
                    Console.WriteLine("...|./.\\.|...");
                    Console.WriteLine("...+-----+...");
                }
                if (choise.ToLower() == "v")
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine("{0:00}.|.\\./.|...", vote);
                    Console.WriteLine("...|..V..|...");
                    Console.WriteLine("...+-----+...");
                }
                for (int i = vote + 1; i <= candidates; i++)
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...", i);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");
                }
                Console.WriteLine(".............");
            }
            else
            {
                for (int i = 1; i <= candidates; i++)
                {
                    Console.WriteLine(".............");
                    Console.WriteLine("...+-----+...");
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0:00}.|.....|...", i);
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("...+-----+...");
                }
                Console.WriteLine(".............");

            }
        }
    }
}
