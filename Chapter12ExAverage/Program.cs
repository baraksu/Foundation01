using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12ExAverage
{
    internal class Program
    {
        public static double Average(int a, int b ,int c)
        {
            a += 2;
            double avg = (double)(a + b + c) / 3;
            return avg;
        }
        static void Main()
        {
            int a = 2;
            double result= Average(a, 4, 6);
            Console.WriteLine(result);
        }
    }
}
