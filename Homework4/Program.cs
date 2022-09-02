using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
       {
           Console.Write("Input a----");
           int a = Convert.ToInt32(Console.ReadLine());
           Console.Write("Input b----");
           int b = Convert.ToInt32(Console.ReadLine());
           Console.Write("Input c----");
           int c = Convert.ToInt32(Console.ReadLine());
           double x1 = 0.0;
           double x2 = 0.0;
           Equation(a,b,c,ref x1, ref x2);
           Console.ReadLine();
       }

       static void Equation( int a, int b, int c, ref double x1, ref double x2)
       {
            x1= 0.0;
            x2 = 0.0;
           double D = b * b - 4 * a * c;
           if (D >= 0)
           {
               x1 = (-b - Math.Sqrt(D)) / (2 * a);
               x2 = (-b + Math.Sqrt(D)) / (2 * a);

           }
           else {
               x1 = -1;
               x2 = -1;
           }
           Console.WriteLine($"x1="+x1);
           Console.WriteLine($"X2="+x2);

       }
            
        }
    }
}
