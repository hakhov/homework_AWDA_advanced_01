using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarOnTheMethod
{
    class Program
    {
        public static void Main()
        {
            (double,double) result = SquareEquation(2, 4, 1);
            Console.WriteLine(result);

        }

        static (double, double) SquareEquation(double A, double B, double C)
        {

            double root1 = -1;
            double root2 = -1;
            double Diskr = Math.Pow(B, 2) - 4 * A * C;
            if (Diskr >= 0)
            {
                root1 = (-B + Math.Sqrt(Diskr)) / (2 * A);
                root2 = (-B - Math.Sqrt(Diskr)) / (2 * A);

            }
            return (root1, root2);

        }
    }
}
