using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,digCount =0;
            Console.WriteLine("Please enter a number");
            num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                digCount = 1;
            }

            while (num!=0)
            {
                
                digCount++;
                num = num / 10;
            }

            Console.WriteLine($"The number has {digCount} digits");
        }
    }
}
