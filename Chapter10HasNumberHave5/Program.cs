using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10HasNumberHave5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool found = false;

            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            int localNumber = number;

            while (!found && localNumber > 0)
            {
                int digit = localNumber % 10;
                if (digit == 5)
                {
                    found = true;

                }

                localNumber = localNumber / 10;

            }

            var result = found ? "has" : "has not";

            Console.WriteLine($"The number:{number} {result} digit 5");

            Console.ReadLine();
        }
    }
}
