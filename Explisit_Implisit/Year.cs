using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explisit_Implisit
{
    public class Year
    {
        public int year;
        public Year(int year)
        {
            this.year = year;
        }

        public static Year operator +(Year year1, Year year2)
        {
            return new Year(year1.year + year2.year);
        }

        public static Year operator -(Year year1, Year year2)
        {
            if (year1.year > year2.year)
            {
                return new Year(year1.year + year2.year);

            }
            else return new Year(0);
        }


        public void Print()
        {
            Console.WriteLine($"Year: {year}");
        }
    }
}
