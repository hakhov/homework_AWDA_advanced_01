using System;

namespace FIB
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib obj = new();
            Console.Write("how many charachters do You want to see -> ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(obj.CalcFib(i)+", ");
            }
            
        }
    }
}
