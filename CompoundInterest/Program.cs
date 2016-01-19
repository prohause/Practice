using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundInterest
{
    class CompoundInterest
    {
        static void Main(string[] args)
        {
            decimal price = decimal.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            decimal bank = decimal.Parse(Console.ReadLine());
            decimal friend = decimal.Parse(Console.ReadLine());
            decimal bankLoan = 0;
            decimal interest = 1;
            for (int i = 0; i < years; i++)
            {
                interest *= (1 + bank);
            }
            bankLoan = price * interest;
            decimal friendLoan = price + price * friend;
            if (friendLoan <= bankLoan)
            {
                Console.WriteLine("{0:F2} Friend", friendLoan);
            }
            else
            {
                Console.WriteLine("{0:F2} Bank", bankLoan);
            }
        }
    }
}
