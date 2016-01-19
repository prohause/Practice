using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = n * n;
            int sumBlack = 0;
            int sumWhite = 0;
            List<char> input = new List<char>(Console.ReadLine().ToCharArray());
            if (input.Count < size)
            {
                for (int i = input.Count; i < size; i++)
                {
                    input.Add(' ');
                }
            }
            for (int i = 1; i <= size; i++)
            {
                if (i % 2 != 0)
                {
                    if (input[i - 1] > 64 && input[i - 1] < 91)
                    {
                        sumWhite += input[i - 1];
                    }
                    if (input[i - 1] > 47 && input[i - 1] < 58 || input[i - 1] > 96 && input[i - 1] < 123)
                    {
                        sumBlack += input[i - 1];
                    }
                }
                else
                {
                    if (input[i - 1] > 64 && input[i - 1] < 91)
                    {
                        sumBlack += input[i - 1];
                    }
                    if (input[i - 1] > 47 && input[i - 1] < 58 || input[i - 1] > 96 && input[i - 1] < 123)
                    {
                        sumWhite += input[i - 1];
                    }
                }
            }
            if (sumBlack > sumWhite)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(sumBlack - sumWhite);
            }
            else if (sumWhite > sumBlack)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(sumWhite - sumBlack);
            }
            else
            {
                Console.WriteLine("Equal result: {0}", sumWhite);
            }
        }
    }
}
