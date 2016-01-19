using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main(string[] args)
        {
            int data = int.Parse(Console.ReadLine());
            decimal movieCount = (decimal)data / 1500;
            decimal timeSpent = (decimal)data / 7200;
            int price = int.Parse(Console.ReadLine());
            int wifeSpent = int.Parse(Console.ReadLine());
            decimal movie = movieCount * price;
            decimal wife = timeSpent * wifeSpent;
            if (movie < wife)
            {
                Console.WriteLine("cinema -> {0:F2}lv", movie);
            }
            else
            {
                Console.WriteLine("mall -> {0:F2}lv", wife);
            }
        }
    }
}
