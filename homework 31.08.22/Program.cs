Console.WriteLine("Please neter number a");
double a =double.Parse(Console.ReadLine());
Console.WriteLine("Please neter number b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Please neter number c");
double c = double.Parse(Console.ReadLine());

Console.WriteLine(GetRoots(ref a,ref b,ref c));



static (double,double) GetRoots( ref double a,ref double b,ref double c)
{
    double x1=-1,x2=-1;
    double D = b * b - 4 * a * c;
    if (D >= 0)
    {
        x1=(-b+Math.Sqrt(D))/2*a; 
        x2 = (-b + Math.Sqrt(D))/2*a;
        return (x1, x2);
    }
    return (x1, x2);
}
