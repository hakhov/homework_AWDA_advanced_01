using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    static string GetRoots(double a, double b, double c)
    {
        double d = b * b - 4 * a * c;
        if (d >= 0)
        {
            d = Math.Sqrt(d);
            string result = "";
            double x1 = (-b + d) / 2 / a;
            double x2 = (-b - d) / 2 / a;
            return result + x1 +" "+ x2;
        }
        else return "roots are not real";
    }
    static void GetRootsWithRef( ref double a, ref double b, ref double c)
    {
        Console.WriteLine("Ax^2+Bx+C");
        Console.Write("type the A of quadratic equation:");
        a = double.Parse(Console.ReadLine());
        Console.Write("type the B of quadratic equation:");
        b = double.Parse(Console.ReadLine());
        Console.Write("type the C of quadratic equation:");
        c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d >= 0)
        {
            d = Math.Sqrt(d);
            (double, double) x = ((-b + d) / 2 / a, (-b - d) / 2 / a);
            Console.WriteLine(x);
        }
        else Console.Write("not real");

    }
}