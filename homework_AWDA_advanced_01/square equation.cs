//With Tuple

//static (double, double) se()
//{
//    double a = double.Parse(Console.ReadLine());
//    double b = double.Parse(Console.ReadLine());
//    double c = double.Parse(Console.ReadLine());
//    double d = b * b - 4 * a * c;
//    if (d >= 0)
//    {
//        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//        return (x1, x2);
//    }
//    else
//        return (-1, -1);

//}

//----------------------------------------------------------------------------------------------------------------------

//Without Tuple

static string se(double a, double b, double c)
{
    double d = b * b - 4 * a * c;
    if (d >= 0)
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        return ($"{x1}, {x2}");
    }
    else
        return ("D<0");

}
Console.WriteLine(se(-1, -1, -1));