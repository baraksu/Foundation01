using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define variables.
            int number1;
            int number2 = 2;
            number1 = number2;

            // types
            long bigNumber = int.MaxValue;
            bigNumber = bigNumber + 1;


            float fraction = 10.5F;

            double fractionWith16PointsAfterDot = 10.123456789012345;


            //char and string
            char tav = 'A';

            string name = "Barak";

            // bool
            bool IsValid = true;


            
            //////// input and output //////////////
            ///
            Console.Out.WriteLine("Please write a number");
            string line  = Console.ReadLine();
            number1 = int.Parse(line);


            //////// input and output //////////////
            ///
            Console.Out.WriteLine("Please write a number");
            number2 = int.Parse(Console.ReadLine());





        }
    }
}
