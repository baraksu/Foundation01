using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter06example04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int result;
            Console.WriteLine("Please enter the big number");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the small number");
            num2= int.Parse(Console.ReadLine());
           
            if (num1 % num2 == 0)
            {
                Console.WriteLine($"{num1} is divided by {num2}");
                result = num1 / num2;
                Console.WriteLine($"The result is {result}");
            }
        }
    }
}
