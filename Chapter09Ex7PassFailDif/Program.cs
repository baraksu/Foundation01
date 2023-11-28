using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09Ex7PassFailDif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, grd;
            int sumPass = 0, sumFail = 0;
            int countPass =0, countFail = 0;
            double avgPass =0, avgFail =0;
            double diffAvg;

            Console.WriteLine("Enter number of students");

            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter students grades");

            // (int i = 1; i <= n; i++) 
            for (int i = 0; i < n; i++)
            {
                grd = int.Parse(Console.ReadLine());

                if (grd >= 55)
                {
                    sumPass= sumPass + grd; //sumPass+=grd
                    countPass++;
                }
                else
                {
                    sumFail += grd;// sumFail = sumFail+ grd
                    countFail += 1;
                }
            }

            if (countPass > 0)
            {
                avgPass = (double)sumPass / countPass;
            }
            else
            {
                avgPass = 0;
            }

            if (countFail > 0)
            {
                avgFail= (double)sumFail / countFail;
            }

            diffAvg = avgPass - avgFail;
            Console.WriteLine($"The difference between the averags is {diffAvg}");

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
