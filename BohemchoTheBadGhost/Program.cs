using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BohemchoTheBadGhost
{
    class Bohemcho
    {
        static void Main(string[] args)
        {
            string input = "";
            uint initial = 0;
            long newnumber = 0;
            int counter = 0;
            while (true)
            {
                input = Console.ReadLine();
                if (input== "Stop, God damn it")
                {
                    break;
                }
                initial = uint.Parse(input);
                string[] apartments = Console.ReadLine().Split(' ');
                for (int i = 0; i < apartments.Length; i++)
                {
                    int mask = int.Parse(apartments[i]);
                    initial = (initial  ^ (1U << mask));
                }
                char[] lights = Convert.ToString(initial, 2).ToCharArray();
                foreach (var item in lights)
                {
                    if (item == '1')
                    {
                        counter++;
                    }
                }
                newnumber += initial;
            }
            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", counter, newnumber);
        }
    }
}
