using System;

namespace DiscriminantWithRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc obj = new();
            double x1 = 0;
            double x2 = 0;
            obj.CalcDisc1(4, 10, 2, ref x1, ref x2);
            Console.WriteLine($"x1={x1}, x2={x2} ");
        }
    }
}
