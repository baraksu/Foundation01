using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Part4InputFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a grade");
            int grade = int.Parse(Console.ReadLine());

            while (grade< 10 || grade> 100)
            {
                Console.WriteLine("Wrong grad, please try again");

                grade = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The grad {grade} is in range");
        }
    }
}


