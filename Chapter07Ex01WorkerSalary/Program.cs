using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07Ex01WorkerSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month,days1,days2;
            double avgPerDay, salary;
            Console.WriteLine("Enter your salary in the last month");

            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the last month (1-12), January->1, February->2 ..");

            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    days1 = 30;
                    break;
                case 2:
                    days1 = 28;
                    break;
                default:
                    days1 = 31;
                    break;
            }

            days2 = days1 - 8;
            Console.WriteLine($"In this month you work:{days1}-8={days2} days");
            avgPerDay = salary / days2;

            Console.WriteLine($"You earned {avgPerDay} on average per days.");
        }
    }
}
