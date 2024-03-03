using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12Exa07Between
{
    internal class Program
    {
        //טענת כניסה: הפעולה מקבלת שני מספרים שלמים
        // טענת יציאה: הפעולה מדפיסה את המספרים בטווח שביניהם

        public static void Print(int n1, int n2)
        {
            int temp;
            if (n1 > n2)
            {
                temp = n1;
                n1 = n2;
                n2 = temp;
            }

            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine($"{i} ");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int num1,num2;
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
               num1 = r.Next(0,101);
                num2 = r.Next(0, 101);
                Print(num1,num2);
            }

        }
    }
}
