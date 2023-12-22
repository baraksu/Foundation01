using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDividedBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;


            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }

            }
            Console.WriteLine("The sum is:" + sum);

        }
    }
}
