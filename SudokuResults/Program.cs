using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuResults
{
    class Sudoku
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string input = "";
            int totaltime = 0;
            while (input != "Quit")
            {
                input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                string[] temp = input.Split(':');
                int minutes;
                int seconds;
                minutes = int.Parse(temp[0]);
                seconds = int.Parse(temp[1]);
                totaltime += minutes * 60 + seconds;
                counter++;
                //    if (success)
                //    {
                //        totaltime.Add(temp);
                //        counter++;
                //    }
            }
            double average = Math.Ceiling((double)totaltime / counter);
            if (average < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (average >= 720 && average <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", counter, (average));
        }
    }
}
