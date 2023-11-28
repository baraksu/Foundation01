using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06Targil27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a student name");
            string firstStudentName = Console.ReadLine();

            Console.WriteLine("Please enter second student name");
            string secondStudentName = Console.ReadLine();

            if (string.Compare(firstStudentName, secondStudentName) < 0)
            {
                Console.WriteLine($"{firstStudentName} before {secondStudentName}");
            }else if (string.Compare(firstStudentName, secondStudentName) == 0)
            {
                Console.WriteLine($"{firstStudentName} equal {secondStudentName}");
            }
            else
            {
                Console.WriteLine($"{firstStudentName} after {secondStudentName}");
            }




        }
    }
}
