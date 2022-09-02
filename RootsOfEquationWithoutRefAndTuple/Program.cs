//Without ref and tuple
Console.Write("a=");
int a = int.Parse(Console.ReadLine());
Console.Write("b=");
int b = int.Parse(Console.ReadLine());
Console.Write("c=");
int c = int.Parse(Console.ReadLine());

GetRoots(a, b, c);

static void GetRoots(int a, int b, int c)
{
    int d = b * b - 4 * a * c;
    if (d > 0)
    {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);
        Console.Write($"x1={x1}, x2={x2}");
    }
    else if (d == 0)
    {
        double x1 = -b / (2 * a);
        double x2 = x1;
        Console.WriteLine($"x0={x1}");
    }
    else
    {
        throw new Exception();
    }
    Console.WriteLine();
}
