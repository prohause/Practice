using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProcesses
{
    class PhoneProcesses
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('%');
            int start = int.Parse(input[0]);
            int appcounter = 0;
            int launched = 0;
            while (true)
            {
                string[] appinput = Console.ReadLine().Split('_');
                if (appinput[0].ToLower() == "end")
                {
                    break;
                }
                appcounter++;
                string[] apppower = appinput[1].Split('%');
                int appconsumed = int.Parse(apppower[0]);
                if (start > 15)
                {
                    if (start -appconsumed > 0)
                    {
                        launched++;
                    }
                    start -= appconsumed;
                }
            }
            if (start <= 0)
            {
                Console.WriteLine("Phone Off");
            }
            else if (start <= 15)
            {
                Console.WriteLine("Connect charger -> {0}%", start);
                Console.WriteLine("Programs left -> {0}", appcounter - launched);
            }
            else
            {
                Console.WriteLine("Successful complete -> {0}%", start);
            }
        }
    }
}
