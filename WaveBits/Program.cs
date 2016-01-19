using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveBits
{
    class WaveBits
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            string binary = "";
            string newbinary = "";
            bool success = false;
            while (input > 0)
            {
                binary = input % 2 + binary;
                input /= 2;
            }
//            Console.WriteLine(binary);
            for (int i = binary.Length / 2 ; i >= 1; i--)
            {
                string replace = string.Concat(Enumerable.Repeat("01", i));
                string replacement = ("1" + replace);
//                Console.WriteLine(replacement);
                int index = binary.LastIndexOf(replacement);
                if (index >= 0)
                {
                    int count = replacement.Length;
                    newbinary = binary.Remove(index, count);
                    success = true;
                    break;
                }
            }
            if (success)
            {
//                Console.WriteLine(newbinary);
                if (newbinary == "")
                {
                    newbinary = "0";
                }
                Console.WriteLine(Convert.ToInt64(newbinary, 2));
            }
            else
            {
                Console.WriteLine("No waves found!");
            }
        }
    }
}
