using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamItem
{
    class DreamItem
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string month = input[0];
            decimal money = decimal.Parse(input[1]);
            int hours = int.Parse(input[2]);
            decimal dream = decimal.Parse(input[3]);
            int days = 0;
            switch (month)
            {
                case "Jan":
                case "March":
                case "May":
                case "July":
                case "Aug":
                case "Oct":
                case "Dec": days = 21; break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov": days = 20; break;
                case "Feb": days = 18; break;
                default:
                    break;
            }
            decimal totalmoney = days * hours * money;
            if (totalmoney > 700)
            {
                totalmoney += (decimal)0.1 * totalmoney;
            }
            decimal total = totalmoney - dream;
            if (total >= 0)
            {
                Console.WriteLine("Money left = {0:F2} leva.", total);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", Math.Abs(total));
            }
        }
    }
}
