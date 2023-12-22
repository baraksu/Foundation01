using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldiersVacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of students");
            int numOfStudent = int.Parse(Console.ReadLine());

            int christianCount = 0;
            int nonChristianCount = 0;

            string christianNames = "";
            string nonChristianNames = "";
            for (int i = 0; i < numOfStudent; i++)
            {
                Console.WriteLine("Is soldier is christian ?");
                bool isChristian = bool.Parse(Console.ReadLine());

                Console.WriteLine("Enter soldier name");
                string name = Console.ReadLine();
                if (isChristian)
                {
                    christianNames += name + "\n";
                    christianCount += 1;
                }
                else
                {
                    nonChristianNames += name + Environment.NewLine;
                    nonChristianCount += 1;
                }

            }

            Console.WriteLine("The following soldiers can go out for holiday");
            Console.WriteLine(christianCount);
            Console.WriteLine(christianNames);

            Console.WriteLine("The following soldiers stay at the base");
            Console.WriteLine(nonChristianCount);
            Console.WriteLine(nonChristianNames);
        }
    }
}
