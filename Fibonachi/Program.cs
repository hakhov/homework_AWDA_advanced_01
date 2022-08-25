using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter how many charachters of fibonachi numbers do You wanna see->");
            int n = int.Parse(Console.ReadLine());
            FiboanchiMethod obj = new();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(obj.CalcFib(i)+" ");
            }
           
        }
    }
}
