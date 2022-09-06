public class Second
{
    public float Seconds { get; set; }

    public static explicit operator float(Second second)
    { return second.Seconds; }

    public static implicit operator Second(int a)
    {
        return new Second { Seconds = a };
    }
}