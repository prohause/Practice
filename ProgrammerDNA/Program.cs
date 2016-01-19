using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammerDNA
{
    class DNA
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Char start = char.Parse(Console.ReadLine());
            int charcounter = 65;
            int endcounter = 71;
            int repeat;
            int rest;
            List<char> dna = new List<char>();
            repeat = n / 7;
            rest = n % 7;
            for (int i = 0; i <= repeat; i++)
            {
                for (int j = 0; j < 24; j++)
                {

                }
            }
        }
    }
}
