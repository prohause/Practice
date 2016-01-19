using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleportPoints
{
    class TeleportPoints
    {
        static void Main(string[] args)
        {
            string[] input;
            input = Console.ReadLine().Split();
            double xa = double.Parse(input[0]);
            double ya = double.Parse(input[1]);
            input = Console.ReadLine().Split();
            double xb = double.Parse(input[0]);
            double yb = double.Parse(input[1]);
            input = Console.ReadLine().Split();
            double xc = double.Parse(input[0]);
            double yc = double.Parse(input[1]);
            input = Console.ReadLine().Split();
            double xd = double.Parse(input[0]);
            double yd = double.Parse(input[1]);
            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            int counter = 0;
            for (double i = 0; i <= radius; i += step)
            {
                for (double h = 0; h <= radius; h += step)
                {
                    if (i < xc && i > xd && i <= radius && h < yc && h > yb && Math.Sqrt(h * h + i * i) <= radius)
                    {
                        counter++;
                    }
                }
            }
            for (double i = 0; i <= radius; i += step)
            {
                for (double h = -step; h >= -radius; h -= step)
                {
                    if (i < xb && i > xa && i <= radius && h > yb && h < yd && Math.Sqrt(h * h + i * i) <= radius)
                    {
                        counter++;
                    }
                }
            }
            for (double i = -step; i >= -radius; i -= step)
            {
                for (double h = 0; h >= -radius; h -= step)
                {
                    if (i > xa && i < xc && i >= -radius && h > yb && h < yc && Math.Sqrt(h * h + i * i) <= radius)
                    {
                        counter++;
                    }
                }
            }
            for (double i = -step; i >= -radius; i -= step)
            {
                for (double h = step; h <= radius; h += step)
                {
                    if (i > xd && i < xc && i >= -radius && h < yd && h > yb && Math.Sqrt(h * h + i * i) <= radius)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
