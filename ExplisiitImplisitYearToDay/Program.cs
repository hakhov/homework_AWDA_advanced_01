using System;

namespace ExplisiitImplisitYearToDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Year year = new();
            Day day = new();
            year.W = 12;
           // day.D = 124;
            //year.M = (Year)day;
            day = (Day)year;
            year = (Year)day;
            Console.WriteLine(year.W);
            Console.WriteLine(year.Y);
            Console.WriteLine(day.D);

            Day day1 = year + day;
            Console.WriteLine(day1.D);
        }
    }
}
