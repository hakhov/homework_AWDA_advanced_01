namespace ExplisiitImplisitYearToDay
{
    internal class Year
    {
        public int Y { get; set;}    
        public int M { get; set; }
        public int W { get; set; }
        public static implicit operator Year(Day day)
        {
            int y = day.D / 365;
            int m = day.D / 31;
            int w = day.D / 7;
            return new Year { Y = y, M = m, W = w };
        }
        public static explicit operator Day(Year year)
        {
            return new Day { D = year.Y * 365 + year.M * 31 + year.W * 7 };
        }
        

    }
}