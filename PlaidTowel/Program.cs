using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class PlaidTowel
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char back = Convert.ToChar(Console.ReadLine());
            char front = Convert.ToChar(Console.ReadLine());
            string string1 = new string(back, size);
            string string3 = new string(back, 2 * size - 1);
            Console.WriteLine(string1 + front + string3 + front + string1);
            for (int i = 1; i < size; i++)
            {
                string1 = new string(back, size - i);
                string string2 = new string(back, 2 * i - 1);
                string3 = new string(back, 2 * (size - i) - 1);
                Console.WriteLine(string1 + front + string2 + front + string3 + front + string2 + front + string1);
            }
            string1 = new string(back, 2 * size - 1);
            Console.WriteLine(front + string1 + front + string1 + front);
            for (int i = size - 1; i >= 1; i--)
            {
                string1 = new string(back, size - i);
                string string2 = new string(back, 2 * i - 1);
                string3 = new string(back, 2 * (size - i) - 1);
                Console.WriteLine(string1 + front + string2 + front + string3 + front + string2 + front + string1);
            }
            string1 = new string(back, size);
            string3 = new string(back, 2 * size - 1);
            Console.WriteLine(string1 + front + string3 + front + string1);
            for (int i = 1; i < size; i++)
            {
                string1 = new string(back, size - i);
                string string2 = new string(back, 2 * i - 1);
                string3 = new string(back, 2 * (size - i) - 1);
                Console.WriteLine(string1 + front + string2 + front + string3 + front + string2 + front + string1);
            }
            string1 = new string(back, 2 * size - 1);
            Console.WriteLine(front + string1 + front + string1 + front);
            for (int i = size - 1; i >= 1; i--)
            {
                string1 = new string(back, size - i);
                string string2 = new string(back, 2 * i - 1);
                string3 = new string(back, 2 * (size - i) - 1);
                Console.WriteLine(string1 + front + string2 + front + string3 + front + string2 + front + string1);
            }
            string1 = new string(back, size);
            string3 = new string(back, 2 * size - 1);
            Console.WriteLine(string1 + front + string3 + front + string1);
        }
    }
}
