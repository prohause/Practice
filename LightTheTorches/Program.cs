using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTheTorches
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string state = Console.ReadLine();
            int repeat = n / state.Length;
            int append = n % state.Length;
            string newinput = "";
            for (int i = 0; i < repeat; i++)
            {
                newinput += state;
            }
            char[] charstate = state.ToCharArray();
            for (int i = 0; i < append; i++)
            {
                newinput += charstate[i];
            }
            char[] roomstate = newinput.ToCharArray();
            int entrance = n / 2 + 1;
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] command = input.Split(' ');
                int moved = int.Parse(command[1]) + 1;
                if (command[0] == "LEFT")
                {
                    if (entrance != 1)
                    {
                        if (entrance - moved < 1)
                        {
                            entrance = 1;
                            if (roomstate[0] == 'L')
                            {
                                roomstate[0] = 'D';
                            }
                            else
                            {
                                roomstate[0] = 'L';
                            }
                        }
                        else
                        {
                            entrance -= moved;
                            if (roomstate[entrance - 1] == 'L')
                            {
                                roomstate[entrance - 1] = 'D';
                            }
                            else
                            {
                                roomstate[entrance - 1] = 'L';
                            }
                        }

                    }
                }
                else
                {
                    if (entrance != n)
                    {
                        if (entrance + moved > n - 1)
                        {
                            entrance = n;
                            if (roomstate[n - 1] == 'L')
                            {
                                roomstate[n - 1] = 'D';
                            }
                            else
                            {
                                roomstate[n - 1] = 'L';
                            }
                        }
                        else
                        {
                            entrance += moved;
                            if (roomstate[entrance - 1] == 'L')
                            {
                                roomstate[entrance - 1] = 'D';
                            }
                            else
                            {
                                roomstate[entrance - 1] = 'L';
                            }
                        }

                    }
                }
                input = Console.ReadLine();
            }
            int counter = 0;
            foreach (var item in roomstate)
            {
                if (item == 'D')
                {
                    counter++;
                }
            }
            int prays = counter * Convert.ToInt16('D');
            Console.WriteLine(prays);
        }
    }
}
