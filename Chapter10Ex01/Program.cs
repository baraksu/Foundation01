using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10Ex01
{
    internal class Program
    {
        // קלט:סדרת מספרים חיובים
        //פלט:מספר המספרים שנקלטו והממוצע שלהם
        static void Main(string[] args)
        {
            int numCounter = 0;
            double num, avg, sum = 0;

            Console.WriteLine("Enter number (-1) for end");
            num = double.Parse(Console.ReadLine());

            while (num != -1)
            {
                numCounter++;
                sum += num;

                num = double.Parse(Console.ReadLine());
            }

            avg = sum / numCounter;
            Console.WriteLine("The number of values is:" + numCounter);
            Console.WriteLine("The average is:" +  avg);

        }
    }
}
