using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09Ex03Boom7V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tens, units;
            int count = 0;

            for (int i = 1; i < 100; i++)
            {
                units = i % 10;
                tens = i / 10;

                if (i % 7 == 0 || units == 7 || tens == 7)
                {
                    count += 1;
                    //count++
                    //++count

                }

                Console.WriteLine($"There are {count} Boom numbers");
                n % i ==0
            }
        }
    }
}
