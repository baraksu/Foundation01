using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10_3Coins
{
    internal class Program
    {
        //קלט: סדרת משקלים של מטבעות
        // פלט: הודעה האם יש בסדרה מטבע מזויף
        static void Main(string[] args)
        {
            double weight;
            bool found = false;
            Console.WriteLine("Enter weights");
            weight = double.Parse(Console.ReadLine());

            while (weight != 100 && !found)
            {
                if (weight < 10)
                {
                    found = true;
                }
                else
                {
                    weight= double.Parse(Console.ReadLine());
                }
            }

            if (found)
            {
                Console.WriteLine("The fake coin is found");

            }
            else
            {
                Console.WriteLine("The fake coin is not found");
            }
        }
    }
}
