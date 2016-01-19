using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class FourFactors
    {
        static void Main(string[] args)
        {
            uint fg = uint.Parse(Console.ReadLine());
            uint fga = uint.Parse(Console.ReadLine());
            uint threep = uint.Parse(Console.ReadLine());
            uint tov = uint.Parse(Console.ReadLine());
            uint orb = uint.Parse(Console.ReadLine());
            uint oppdrb = uint.Parse(Console.ReadLine());
            uint ft = uint.Parse(Console.ReadLine());
            uint fta = uint.Parse(Console.ReadLine());
            double efgpercent;
            double tovpercent;
            double orbpercent;
            double ftpercent;

            efgpercent = ((fg + (0.5 * threep)) / fga);
            Console.WriteLine("eFG% {0:F3}", efgpercent);
            tovpercent = (tov / (fga + (0.44 * fta) + tov));
            Console.WriteLine("TOV% {0:F3}", tovpercent);
            orbpercent = ((double)orb / (orb + oppdrb));
            Console.WriteLine("ORB% {0:F3}", orbpercent);
            ftpercent = ((double)ft / fga);
            Console.WriteLine("FT% {0:F3}", ftpercent);
        }
    }
}
