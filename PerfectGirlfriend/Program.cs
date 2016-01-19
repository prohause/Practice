using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectGirlfriend
{
    class Girlfriend
    {
        static void Main(string[] args)
        {
            string input = "";
            string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int perfect = 0;
            List<string> output = new List<string>();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Enough dates!")
                {
                    break;
                }
                string[] dates = input.Split('\\');
                int sum = 0;
                for (int i = 0; i < week.Length; i++)
                {
                    if (dates[0] == week[i])
                    {
                        sum = i + 1;
                    }
                }
                char[] phone = dates[1].ToCharArray();
                foreach (var item in phone)
                {
                    sum += int.Parse(Convert.ToString(item));
                }
                char[] bra = dates[2].ToCharArray();
                int counter = bra.Length - 1;
                int bracounter = 0;
                int temp = 0;
                while (counter > 0)
                {
                    temp += int.Parse(Convert.ToString(bra[bracounter])) * (int)Math.Pow(10, counter - 1);
                    counter--;
                    bracounter++;
                }
                sum += temp * (bra[bra.Length - 1]);
                char[] name = dates[3].ToCharArray();
                sum -= name[0] * name.Length;
                if (sum >= 6000)
                {
                    perfect++;
                    StringBuilder tempoutput = new StringBuilder(dates[3] + " is perfect for you.");
                    output.Add(Convert.ToString(tempoutput));
                }
                else
                {
                    StringBuilder tempoutput = new StringBuilder("Keep searching, " + dates[3] +" is not for you.") ;
                    output.Add(Convert.ToString(tempoutput));
                }
            }
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(perfect);
        }
    }
}
