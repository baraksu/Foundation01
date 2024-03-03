using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12Exe01SumOfDigits
{
    internal class Program
    {
        public static int DigitsSum(int num)
        {
            // טענת כניסה: הפעולה מקבלת מספר שלם
            // טענת יציאה: הפעולה מחזירה את סכום ספרותיו
            int digSum = 0;
            while (num > 0)
            {
                digSum += num % 10;
                num /= 10;
            }
            return digSum;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 integer numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum1 = DigitsSum(num1);
            int sum2 = DigitsSum(num2);

            if (sum1 > sum2)
            {
                Console.WriteLine("The big digits sum belong to number " + num1);
            }else if (sum1 < sum2)
            {
                Console.WriteLine($"The big digits sum belong to number {sum2}");
            }
            else
            {
                Console.WriteLine("The nuber have equal digits sum");
            }
        }
    }
}
