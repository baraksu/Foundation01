using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11Ex02Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grd, sum, count, best = 0;
            double avg;

            for (int i = 1; i <= 38; i++)
            {
                sum = 0;
                count = 0;
                Console.WriteLine($"Enter a grade for student {i}");
                grd = int.Parse(Console.ReadLine());

                while (grd != -999)
                {
                    sum += grd;
                    count++;
                    Console.WriteLine("Enter another grade or -999 for exit.");
                    grd = int.Parse(Console.ReadLine());

                }

                avg = (double)sum / count;

                Console.WriteLine($"The average of stud num {i} is {avg}");
                ;
                if (avg > 90)
                {
                    best++;
                }
            }

            Console.WriteLine($"There are {best} excellent students ");
            }
    }
}
