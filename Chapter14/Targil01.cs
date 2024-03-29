﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    internal class Targil01
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

            Circle c2 = new Circle(1, "red");

            var c3 = new Circle();

            double area = c1.GetArea();
            double p = Circle.GetPI();

            MultipleRadiusBy2(c2);
            Console.WriteLine($"c2 new radius is {c2.GetRadius()}");

            int a = 5;
            Add(a);
            Console.WriteLine(a);
        }
        public static void MultipleRadiusBy2(Circle circle)
        {
            circle.SetRadius( 2 * circle.GetRadius());
        }
        public static void Add(int  a)
        {
            a = a + 1;
        }

        public static int GetSumOfRadius (Circle circule_1, Circle circule_2)
        {
            return circule_1.GetRadius() + circule_2.GetRadius();

        }
       
        public static Circle GetBigCircule (Circle circule_1, Circle circule_2)
        {
            int sumOfRadius = GetSumOfRadius(circule_1, circule_2);

            return new Circle(color: "red",radius: sumOfRadius);

        }
        public static void PrintCircle(Circle circule_1)
        {
            Console.WriteLine($" Circule.GetRadius():{circule_1.GetRadius()}, Circle.Color:{circule_1.GetColor()}");

        }

    }
}
