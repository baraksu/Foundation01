using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09Ex088Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double max, weight;
            Console.WriteLine("Enter a ball weight");
            weight = double.Parse(Console.ReadLine());
            max = weight;

            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine("Enter a ball weight");
                weight = double.Parse(Console.ReadLine());
                if (weight > max)
                {
                    max = weight;
                }
            }

            Console.WriteLine("The heaviest ball is :" + max);

            ////////////////  second solution //////////////////////
            
            Console.WriteLine("My Solution");
            
            weight = -1;
            max = -1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a ball weight");
                weight = double.Parse(Console.ReadLine());
                if (weight > max)
                {
                    max = weight;
                }
            }
            Console.WriteLine("The heaviest ball is :" + max);
        }
    }
}
