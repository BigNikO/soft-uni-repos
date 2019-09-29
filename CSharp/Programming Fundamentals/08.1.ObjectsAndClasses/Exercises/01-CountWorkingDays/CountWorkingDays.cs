﻿using System;
using System.Globalization;
namespace Ex1CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            string inputFirstDate = Console.ReadLine();
            DateTime firstDate = DateTime.ParseExact(inputFirstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string inputSecondDate = Console.ReadLine();
            DateTime secondDate = DateTime.ParseExact(inputSecondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            long workingDays = 0;
            for (DateTime i = firstDate; i <= secondDate; i = i.AddDays(1))
            {
               if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && !(i.Month == 1 && i.Day == 1)
                   && !(i.Month == 3 && i.Day == 3) && !(i.Month == 5 && i.Day == 1) && !(i.Month == 5 && i.Day == 6)
                   && !(i.Month == 5 && i.Day == 24) && !(i.Month == 9 && i.Day == 6) && !(i.Month == 9 && i.Day == 22)
                   && !(i.Month == 11 && i.Day == 1) && !(i.Month == 12 && i.Day == 24) && !(i.Month == 12 && i.Day == 25)
                   && !(i.Month == 12 && i.Day == 26))
               {
                   workingDays++;
               }
            }
            Console.WriteLine(workingDays);
        }
    }
}
