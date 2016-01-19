using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFootballStatistician
{
    class Statistician
    {
        static void Main(string[] args)
        {
            string[] teams = { "Arsenal", "Chelsea", "Everton", "Liverpool", "ManchesterCity", "ManchesterUnited", "Southampton", "Tottenham" };
            string[] teams1 = { "Arsenal", "Chelsea", "Everton", "Liverpool", "Manchester City", "Manchester United", "Southampton", "Tottenham" };
            int[] score = new int[8];
            decimal payment = decimal.Parse(Console.ReadLine()) * 1.94m;
            int counter = 0;
            string input = Console.ReadLine();
            while (input != "End of the league.")
            {
                counter++;
                string[] result;
                result= input.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                if (result[1] == "1")
                {
                    for (int i = 0; i < teams.Length; i++)
                    {
                        if (teams[i] == result[0])
                        {
                            score[i] += 3;
                        }
                    }
                }
                else if (result[1] == "2")
                {
                    for (int i = 0; i < teams.Length; i++)
                    {
                        if (teams[i] == result[2])
                        {
                            score[i] += 3;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < teams.Length; i++)
                    {
                        if (teams[i] == result[0] || teams[i] == result[2])
                        {
                            score[i] += 1;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("{0:F2}lv.", counter * payment);
            for (int i = 0; i < teams1.Length; i++)
            {
                Console.WriteLine("{0} - {1} points.", teams1[i], score[i]);
            }
        }
    }
}
