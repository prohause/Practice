using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiIvanAdventures
{
    class BayIvan
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double desire = double.Parse(Console.ReadLine());
            double price = 0;
            switch (day)
            {
                case 0: price = 25.00; break;
                case 1: price = 21.00; break;
                case 2: price = 14.00; break;
                case 3: price = 17.00; break;
                case 4: price = 45.00; break;
                case 5: price = 59.00; break;
                case 6: price = 42.00; break;
                default:
                    break;
            }
            double consumed = money / price;
            string condition = "";
            if (consumed > 1.5)
            {
                condition = "very drunk";
            }
            else if (consumed >= 1 && consumed <= 1.5)
            {
                condition = "drunk";
            }
            else
            {
                condition = "sober";
            }
            if (consumed > desire)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends", condition, (consumed - desire));
            }
            else if (consumed == desire)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol", condition, desire - consumed);
            }
        }
    }
}
