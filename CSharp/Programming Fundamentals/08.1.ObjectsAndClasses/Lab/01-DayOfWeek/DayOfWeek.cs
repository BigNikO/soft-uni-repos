﻿using System;
using System.Globalization;

namespace Lab1DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            {
                string dateAsText = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.DayOfWeek);
            }
        }
    }
}
