namespace ExplisiitImplisitYearToDay
{
    internal class Day
    {
       public int D { get; set; }

        //public static implicit operator Day(Year year)
        //{
        //    return new Day { D = year.Y * 365 + year.M * 31 + year.W * 7 };
        //}
        //public static explicit operator Year(Day day)
        //{

        //    int y = day.D / 365;
        //    int m = day.D / 31;
        //    int w = day.D / 7;
        //    return new Year { Y = y, M = m, W = w };
        //}
        public static Day operator +(Year year, Day day)
        {
            Day day1 = new Day();
            day1.D = year.Y * 365 + year.M * 31 + year.W * 7 + day.D;
            return day1;
        }
        public static Day operator -(Year year, Day day)
        {
            Day day1 = new Day();
            day1.D = year.Y * 365 + year.M * 31 + year.W * 7 - day.D;
            return day1;
        }
        public static Day operator *(Day day, int X)
        {
            Day day1 = new Day();
            day1.D =day.D*X;
            return day1;
        }
        public static Day operator /(Day day, int X)
        {
            Day day1 = new Day();
            day1.D = day.D / X;
            return day1;
        }
    }
}