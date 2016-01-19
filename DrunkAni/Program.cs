using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrunkAni
{
    class DrunkAni
    {
        static void Main(string[] args)
        {
            uint toilets = uint.Parse(Console.ReadLine());
            string input = "";
            long steptaken = 0;
            uint currentCabin = 1;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "Found a free one!")
                {
                    break;
                }
                uint steps = uint.Parse(input);
                uint stepsToTake = steps % toilets;
                if (steps%toilets == 0)
                {
                    Console.WriteLine("Stay there, Ani.");
                }
                else
                {
                    if (stepsToTake%toilets + currentCabin <= toilets)
                    {
                        Console.WriteLine("Go {0} steps to the right, Ani.", stepsToTake);
                        steptaken += stepsToTake;
                        currentCabin += stepsToTake;
                    }
                    else
                    {
                        Console.WriteLine("Go {0} steps to the left, Ani.", currentCabin - (currentCabin + stepsToTake)%toilets);
                        steptaken += (currentCabin - (currentCabin + stepsToTake) % toilets);
                        currentCabin = (currentCabin + stepsToTake)%toilets;
                    }
                }
            }
            Console.WriteLine("Moved a total of {0} steps.",steptaken);
        }
    }
}
