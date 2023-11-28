using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ten = 10;
            int three = 3;
            int div = 10 / 3;
            int remainder = 10 % 3;

            Console.WriteLine($"{ten}/{three}= {div} ({remainder})");

            ////////// דוגמא פתורה 01 /////////////

            int num, tens, units, sum;
            num = int.Parse(Console.ReadLine());
            tens = num / 10;
            units = num % 10;
            sum = tens + units;
            Console.WriteLine($"The tens digits:{tens}, the units digit:{units}");
            Console.WriteLine($"The digits sum is {sum}");

            ///// שאלה 2.2 /////////////////////
            ///
            int orangesInBox = 20;
            int grapefruitInBox = 12;
            int pummelsInBox = 4;

            
            Console.WriteLine("Insert Oranges");
            int orag = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert grapefruits");
            int grp=int.Parse(Console.ReadLine());
            Console.WriteLine("Insert Pummels");
            int pml = int.Parse(Console.ReadLine());

            int boxForOranges = orag / orangesInBox;
            int boxForGrapefruits = grp / grapefruitInBox;
            int boxForPummels = pml / pummelsInBox;

            int boxes = Math.Min(boxForOranges, boxForGrapefruits);
            boxes = Math.Min(boxes, boxForPummels);

            Console.WriteLine($"Number of boxes:{boxes}");
            
            int orangeReminder = orag % orangesInBox;

            Console.WriteLine($"Orange Reminder:{orangeReminder}");

            ////////////////// Math //////////////////////
            
            int max = Math.Max(4, 7);
            double squareRoot =  Math.Sqrt(36); // פעולת שורש
            int abs = Math.Abs(-3);// ערך מוחלט
            double round = Math.Round(9.99); // עיגול למספר הקרוב
            double floor = Math.Floor(9.99);// למספר העגול הנמוך
            double ceiling = Math.Ceiling(10.01);// למספר העגול הגבוהה

            Console.WriteLine();





        }
    }
}
