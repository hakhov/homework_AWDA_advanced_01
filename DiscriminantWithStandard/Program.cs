using System;

namespace DiscriminantWithStandard
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcWithStandard obj = new();
            var result=obj.CalcDisc1(2, 4, 1);
            
            Console.WriteLine($"x1={result.x1}, x2={result.x2}");
        }
    }
}
