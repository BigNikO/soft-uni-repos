﻿namespace RectangleArea
{
    using System;
    class RectangleArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a*b;
            Console.WriteLine("{0:f2}",area);

        }
    }
}
