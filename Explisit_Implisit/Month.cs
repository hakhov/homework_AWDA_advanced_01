using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explisit_Implisit
{
    public class Month
    {
        public int month;
        public Month(int month)
        {
            this.month = month;
        }

        public static explicit operator Day(Month m)
        {
            return new Day(m.month * 30);
        }
        public static implicit operator Month(Day d)
        {
            return new Month(d.day / 30);
        }
        public static explicit operator Year(Month m)
        {
            return new Year(m.month / 12);
        }
        public static implicit operator Month(Year y)
        {
            return new Month(y.year * 12);
        }

        public static Month operator +(Month month1, Month month2)
        {
            return new Month(month1.month + month2.month);
        }

        public static Month operator -(Month month1, Month month2)
        {
            if (month1.month > month2.month)
            {
                return new Month(month1.month - month2.month);

            }
            else return new Month(0);
        }




        public void Print()
        {
            Console.WriteLine($"Month: {month}");
        }
    }
}
