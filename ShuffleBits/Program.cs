using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleBits
{
    class Shuffle
    {
        static void Main(string[] args)
        {
            uint inta = uint.Parse(Console.ReadLine());
            uint intb = uint.Parse(Console.ReadLine());
            string first = Convert.ToString(inta, 2).PadLeft(32, '0');
            string second = Convert.ToString(intb, 2).PadLeft(32, '0');
            char[] firstbinary = first.ToCharArray();
            char[] secondbinary = second.ToCharArray();
            string output = "";
            if (inta >= intb)
            {
                for (int i = 0; i < firstbinary.Length; i++)
                {
                    output = output + (Convert.ToString(firstbinary[i]) + Convert.ToString(secondbinary[i]));
                }
            }
            else
            {
                for (int i = 0; i < firstbinary.Length; i += 2)
                {
                    output = output + (Convert.ToString(firstbinary[i]) + Convert.ToString(firstbinary[i + 1])
                        + Convert.ToString(secondbinary[i]) + Convert.ToString(secondbinary[i + 1]));
                }

            }
            Console.WriteLine(Convert.ToUInt64(output, 2));
        }
    }
}
