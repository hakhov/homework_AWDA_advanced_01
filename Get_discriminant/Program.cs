//Լուծել քառակուսային հավասարումը առանց ref-ի
Console.Write("a=");
double a = double.Parse(Console.ReadLine());
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.Write("c=");
double c = double.Parse(Console.ReadLine());
Dis(a, b, c);
static void Dis(double a, double b, double c)
{
    double x, x1, x2;
    double d = b * b - 4 * a * c;
    if (d > 0)
    {
        x1 = (-b + Math.Sqrt(d)) / (2 * a);
        x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.WriteLine($"x1={x1}, x2={x2}");
    }
    else
        if (d == 0)
    {
        x = -b / (2 * a);
        Console.WriteLine($"x={x}");
    }
    else
        Console.WriteLine("Error");
}
