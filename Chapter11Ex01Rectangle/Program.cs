using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Ex01Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght, width;
            Console.WriteLine("Insert length");
            lenght = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert width");
            width = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
