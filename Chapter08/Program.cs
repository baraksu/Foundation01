using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number01 = random.Next(6); // Random number from [0,6)

            int number02 = random.Next(2,6);//Random number form [2,6)


            // דוגמא פתורה 02 //////

            int n1, n2, n3, max1, max2;
            double d1, d2, d3;
            int sqrt1, sqrt2, sqrt3;

            Random random01 = new Random();
            // random numbers
            
            n1 = random01.Next(20, 41);
            n2 = random01.Next(20, 41);
            n3 = random01.Next(20, 41);

            // double from 20-70
            d1 = 20 + random01.NextDouble() * (50);
            d2 = 20 + random01.NextDouble() * (50);
            d3 = 20 + random01.NextDouble() * (50);
            Console.WriteLine($"The numbers are n1:{n1}, n2:{n2}, n3:{n3}");
            // max number
            max1 = Math.Max(n1, n2);
            max2 = Math.Max(max1, n3);

            Console.WriteLine($" The biggest number is {max2}");

            sqrt1 = (int)Math.Round(Math.Sqrt(n1));
            sqrt2 = (int)Math.Round(Math.Sqrt(n2));
            sqrt3 = (int)Math.Round(Math.Sqrt(n3));

            if (sqrt1 == sqrt2 || sqrt2 == sqrt3 || sqrt3 == sqrt1)
            {
                Console.WriteLine("At least 2 numbers have the same round sqrt");
            }
            else
            {
                Console.WriteLine("All numbers have different round sqrt");
            }
        }
    }
}
