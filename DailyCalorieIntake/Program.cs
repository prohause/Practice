using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCalorieIntake
{
    class CalorieIntake
    {
        static void Main(string[] args)
        {
            double weight = int.Parse(Console.ReadLine()) / 2.2;
            double height = int.Parse(Console.ReadLine()) * 2.54;
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int workout = int.Parse(Console.ReadLine());
            decimal bmr = 0;
            decimal dci = 0;
            if (gender == 'm')
            {
                bmr = (decimal)(66.5 + (13.75 * weight) + (5.003 * height) - (6.755 * age));
            }
            else if (gender == 'f')
            {
                bmr = (decimal)(655 + (9.563 * weight) + (1.850 * height) - (4.676 * age));
            }
            else
            {
                Console.WriteLine("Invalid input fo gender!");
            }
            if (workout < 0)
            {
                workout = 0;
            }
            switch (workout)
            {
                case 0: dci = Math.Floor(bmr * (decimal)1.2); break;
                case 1:
                case 2:
                case 3: dci = Math.Floor(bmr * (decimal)1.375); break;
                case 4:
                case 5:
                case 6: dci = Math.Floor(bmr * (decimal)1.55); break;
                case 7:
                case 8:
                case 9: dci = Math.Floor(bmr * (decimal)1.725); break;
                default:
                    dci = Math.Floor(bmr * (decimal)1.9);
                    break;
            }
            Console.WriteLine(dci);
        }
    }
}
