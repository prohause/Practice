using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBetterMusicProducer
{
    class MusicProducer
    {
        static void Main(string[] args)
        {
            decimal income1 = 0;
            decimal income2 = 0;
            int albums = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine()) * (decimal)1.94;
            income1 += albums * price;
            albums = int.Parse(Console.ReadLine());
            price = decimal.Parse(Console.ReadLine()) * (decimal)1.72;
            income1 += albums * price;
            albums = int.Parse(Console.ReadLine());
            price = decimal.Parse(Console.ReadLine()) / (decimal)332.74;
            income1 += albums * price;
            albums = int.Parse(Console.ReadLine());
            price = decimal.Parse(Console.ReadLine()) * (decimal)1.94;
            income2 += albums * price;
            income1 -= (decimal)0.35 * income1;
            income1 -= (decimal)0.20 * income1;
            if (income2 > 100000 )
            {
                income2 -= (decimal)0.15 * income2;
            }
            if (income1 > income2)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", income1);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", income2);
            }
        }
    }
}
