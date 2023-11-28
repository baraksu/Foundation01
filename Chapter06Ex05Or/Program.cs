using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06Ex05Or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = int.Parse(Console.ReadLine());
            if (num1 % 7 == 0 || 
                num1 / 10 == 7 || 
                num1 % 10 == 7)
            {
                Console.WriteLine("Boom");
            }
        }
    }
}
