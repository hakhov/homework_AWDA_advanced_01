Console.Write("Enter a = ");
double a = double.Parse(Console.ReadLine());
Console.Write("Enter b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("Enter c = ");
double c = double.Parse(Console.ReadLine());
GetRoots(a, b, c);

static double[] GetRoots(double a,double b,double c)
{
    double d = b * b - 4 * a * c;
    int x = 0;
    if (d == 0)
        x = 1;
    if (d > 0)
        x = 2;
    double[] arr = new double[x];
    if (d > 0)
    {
        arr[0] = (-b + Math.Sqrt(d)) / (2 * a);
        arr[1] = (-b - Math.Sqrt(d)) / (2 * a);
        for (int i = 0; i < 2; i++)
        {
            Console.Write($"{arr[i]}\t");
        }
    }
    else if (d == 0)
    {
        arr[0] = (-b) / 2 * a;
        Console.WriteLine(arr[0]);
    }
    else if (d < 0)
        throw new Exception("Quadratic equation does not have roots");

    return arr;

}