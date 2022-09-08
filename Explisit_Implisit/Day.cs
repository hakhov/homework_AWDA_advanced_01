public class Day
{
    public int Days { get; set; }

    public Day()
    {

    }
    public Day(int day)
    {
        Days = day;
    }

    public static explicit operator int(Day day)
    {
        return day.Days;
    }
    public static implicit operator Day(int a)
    {
        return new Day { Days = a };
    }

}