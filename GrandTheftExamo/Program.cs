using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandTheftExamo
{
    class GrandTheftExamo
    {
        static void Main(string[] args)
        {
            int attempts = int.Parse(Console.ReadLine());
            ulong slaped = 0;
            ulong escaped = 0;
            ulong beer = 0;
            for (int i = 1; i <= attempts; i++)
            {
                ulong thieves = ulong.Parse(Console.ReadLine());
                if (thieves > 5)
                {
                    slaped += 5;
                    escaped += thieves - 5;
                }
                else
                {
                    slaped += thieves;
                }
                beer += ulong.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0} thieves slapped.", slaped);
            Console.WriteLine("{0} thieves escaped.", escaped);
            Console.WriteLine("{0} packs, {1} bottles.", beer / 6, beer % 6);
        }
    }
}
