using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter06Sample02Boom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            if (num % 7 == 0)
            {
                Console.WriteLine("Boom");
            }
        }
    }
}
