public class Time
{
    public int Y { get; set; }
    public int M { get; set; }
    public int D { get; set; }

    public static implicit operator Time(Day day)
    {
        int y = day.Days / 365;
        int m = day.Days / 30;
        int d = day.Days;
        return new Time { Y = y, M = m, D = d };
    }

    public static explicit operator Day(Time time)
    {
        return new Day { Days = time.Y * 365 + time.M * 30 + time.D };
    }

}