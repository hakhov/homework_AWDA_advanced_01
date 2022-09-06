public class Year
{
    public float Y { get; set; }
    public float Mt { get; set; }
    public float D { get; set; }
    public float H { get; set; }
    public float M { get; set; }
    public float S { get; set; }

    public static implicit operator Year(Second second)
    {
        float h = (float)second.Seconds / 3600;
        float m = (float)second.Seconds / 60;
        float s = second.Seconds;
        float d = (float)h / 24;
        float mt = (float)d / 30;
        float y = (float)mt / 12;
        return new Year { H = h, M = m, S = s, D = d, Mt = mt, Y = y };
    }

    public static explicit operator Second(Year year)
    {
        return new Second { Seconds = year.Y * 12 + year.Mt * 30 + year.D * 24 + year.H * 3600 + year.M * 60 + year.S };
    }
}
