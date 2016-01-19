using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatcher
{
    class ArrayMatcher
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            char[] array1 = input[0].ToCharArray();
            char[] array2 = input[1].ToCharArray();
            string output = "";
            if (input[2] == "join")
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            output += Convert.ToString(array1[i]);
                        }
                    }
                }
            }
            else if (input[2] == "right exclude")
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        output += Convert.ToString(array1[i]);
                    }
                }
            }
            else if (input[2] == "left exclude")
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < array1.Length; j++)
                    {
                        if (array1[j] == array2[i])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        output += Convert.ToString(array2[i]);
                    }
                }
            }
            char[] newOutput = output.ToCharArray();
            Array.Sort<char>(newOutput);
            foreach (var item in newOutput)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
