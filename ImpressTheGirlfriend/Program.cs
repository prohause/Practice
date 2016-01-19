using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalExam
{
    class ImpressTheGirlfriend
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine())*0.035;
            double d = double.Parse(Console.ReadLine()) * 1.5;
            double e = double.Parse(Console.ReadLine()) * 1.95;
            double b = double.Parse(Console.ReadLine()) / 2;
            double m = double.Parse(Console.ReadLine());
            List<double> prices = new List<double> { r, d, e, b, m };
            Console.WriteLine("{0:F2}", Math.Ceiling(prices.Max()));
        }
    }
}
