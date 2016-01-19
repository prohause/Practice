using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeThePlaneDown
{
    class PlaneDown
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] planes = new int[n, 2];
            int counter = -1;
            for (int i = 0; i < n; i++)
            {
                int planeX = int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());
                int distance = (planeX - x) * (planeX - x) + (planeY - y) * (planeY - y);
                if (r * r >= distance)
                {
                    counter++;
                    planes[counter, 0] = planeX;
                    planes[counter, 1] = planeY;
                }
            }
            if (counter >= 0)
            {
                for (int i = 0; i <= counter; i++)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planes[i, 0], planes[i, 1]);
                }
            }
        }
    }
}
