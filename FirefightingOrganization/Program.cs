using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirefightingOrganization
{
    class FirefightingOrganization
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string input = "";
            int left = 0;
            int savedkids = 0;
            int savedadults = 0;
            int savedseniors = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "rain")
                {
                    break;
                }
                left = number;
                int kids = 0;
                int adults = 0;
                int seniors = 0;
                char[] people = input.ToCharArray();
                for (int i = 0; i < people.Length; i++)
                {
                    if (people[i] == 'K')
                    {
                        kids++;
                    }
                    if (people[i] == 'A')
                    {
                        adults++;
                    }
                    if (people[i] == 'S')
                    {
                        seniors++;
                    }
                }
                if (kids>=number)
                {
                    left = 0;
                    savedkids += number;
                }
                else
                {
                    savedkids += kids;
                    left -= kids;
                }
                if (left > 0)
                {
                    if (adults >= left)
                    {
                        savedadults += left;
                        left = 0;
                    }
                    else
                    {
                        savedadults += adults;
                        left -= adults;
                    }
                }
                if (left > 0)
                {
                    if (seniors >= left)
                    {
                        savedseniors += left;
                    }
                    else
                    {
                        savedseniors += seniors;
                    }
                }
            }
            Console.WriteLine("Kids: {0}", savedkids);
            Console.WriteLine("Adults: {0}", savedadults);
            Console.WriteLine("Seniors: {0}", savedseniors);
        }
    }
}
