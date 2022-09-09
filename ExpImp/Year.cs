public class Year
{
    public int y { get; set; }  
    public int m { get;set; }
    public int d { get;set; }
    
    public static implicit operator Year(Day day)
    {
        int year = day.Myday / 365;
        int month = day.Myday / 30;
        int day2 = day.Myday;
        return new Year { d = day2, m = month, y = year };
    }
    public static explicit operator Day(Year year)
    {

        return new Day { Myday = year.y * 365 + year.m * 30 + year.d };
    }

}