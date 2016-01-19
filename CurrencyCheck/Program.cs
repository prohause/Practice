using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            List<decimal> price = new List<decimal>();
            price.Add(decimal.Parse(Console.ReadLine()) * (decimal)0.035);
            price.Add(decimal.Parse(Console.ReadLine()) * (decimal)1.5);
            price.Add(decimal.Parse(Console.ReadLine()) * (decimal)1.95);
            price.Add(decimal.Parse(Console.ReadLine()) / 2);
            price.Add(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("{0:F2}", price.Min());
        }
    }
}
