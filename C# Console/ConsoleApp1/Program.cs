using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube Test = new Cube(10,10,10,10);
            List<Tri> Trilist = Test.GenerateTris();
            string[,,] grid = new string[30, 30, 30];
            foreach(Tri i in Trilist)
            {
                //for (double value = i.point1[1]; value < i.point2[1]; value++)
                //{
                //    grid[Convert.ToInt32(value), Convert.ToInt32(i.point1[2]), Convert.ToInt32(i.point1[3])] = "*";
                //}
                //for (double value = i.point1[1]; value < i.point2[1]; value++)
                //{
                //    grid[Convert.ToInt32(value), Convert.ToInt32(i.point1[2]), Convert.ToInt32(i.point1[3])] = "*";
                //}

                grid[Convert.ToInt32(i.point1[0]), Convert.ToInt32(i.point1[1]), Convert.ToInt32(i.point1[2])] = "*";
                grid[Convert.ToInt32(i.point2[0]), Convert.ToInt32(i.point2[1]), Convert.ToInt32(i.point3[2])] = "*";
                grid[Convert.ToInt32(i.point3[0]), Convert.ToInt32(i.point3[1]), Convert.ToInt32(i.point3[2])] = "*";

            }
            Console.ReadKey();
            for (int x = 0; x < 29; x++)
            {
                for (int y = 0; y < 29; y++)
                {
                    Console.WriteLine("");
                    for (int z = 0; z < 29; z++)
                    {
                        Console.Write(grid[x, y, z]);
                    }
                }
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
