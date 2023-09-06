using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // assignment 
            double number = 3.14;
            number = number * 2;
            
            const double PI = 3.14;

            char tav = 'a';

            int targil = 2 + 2 * 2;

            int i = 1;

            i = i + 1;

            // casting int double /////////
            int count = 1;
            double max = count;

            count = (int)max;


            ///////// casting int char //////////
            char character = 'a';

            int ascii_code = character;

            ascii_code += 1;

            character = (char)ascii_code;

            //////////  special operation.
            
            int index = 1;
            int next_index = index++;
            int another_next_index = ++index;
            int anoter_one = index;





        }
    }
}
