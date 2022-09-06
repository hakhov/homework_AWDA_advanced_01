using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explisit_Implisit
{
    public class Day
    {
        public int day;
        public Day(int day)
        {
            this.day = day;
        }

        public static explicit operator Year(Day d)
        {
            return new Year(d.day / 365);
        }
        public static implicit operator Day(Year y)
        {
            return new Day(y.year * 365);
        }

        public static Day operator +(Day day1, Day day2)
        {
            return new Day(day1.day + day2.day);
        }

        public static Day operator -(Day day1, Day day2)
        {
            if (day1.day > day2.day)
            {
                return new Day(day1.day - day2.day);

            }
            else return new Day(0);
        }



        public void Print()
        {
            Console.WriteLine($"Days: {day}");
        }
    }
}
