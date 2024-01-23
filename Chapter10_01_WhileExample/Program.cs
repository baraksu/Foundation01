using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_01_WhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mone = 0;

            while (mone<5)
            {
                Console.WriteLine("Hello");
                mone += 1;
            }
        }
    }
}
