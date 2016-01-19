using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ProspectInHospitality
{
    class Hospitality
    {
        static void Main(string[] args)
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint others = uint.Parse(Console.ReadLine());
            decimal nSalary = decimal.Parse(Console.ReadLine());
            decimal cRate = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal needed = (decimal)((builders * 1500.04) + (receptionists * 2102.10) + (chambermaids * 1465.46)
                            + (technicians * 2053.33) + (others * 3010.98)) + (nSalary * cRate) + (mySalary);
            Console.WriteLine("The amount is: {0:F2} lv.", needed);
            if (needed <= budget)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", (budget - needed));
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", (needed - budget));
            }
        }
    }
}
