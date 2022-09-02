Console.Write("Enter a = ");
double a = double.Parse(Console.ReadLine());

Console.Write("Enter b = ");
double b = double.Parse(Console.ReadLine());

Console.Write("Enter c = ");
double c = double.Parse(Console.ReadLine());

GetRoots( a,ref b,ref c);

static void GetRoots(double a,ref double b,ref double c)
{
    double d = b * b - 4 * a * c;

    if (d < 0)
    {
        throw new Exception("Quadratic equation does not have roots");
    }
    else if (d == 0)
    {
        c = (-b) / 2 * a;
        Console.WriteLine(c);
    }
    else if (d > 0)
    {
        c = (-b + Math.Sqrt(d)) / (2 * a);
        b = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"{c}\t{b}");
    }
}
