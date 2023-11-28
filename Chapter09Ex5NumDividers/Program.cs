using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09Ex5NumDividers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,dividers = 0;
            Console.WriteLine("Enter an integer number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("num = "+ num);
            Console.WriteLine("The dividers are:");

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    dividers++;// dividers+=1;// ++dividers 
                }
            }
            Console.WriteLine("Numbers of dividers:" + dividers);
        }
    }
}
