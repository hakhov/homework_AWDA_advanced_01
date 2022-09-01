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
            double firstCoefficient = Convert.ToDouble(Console.ReadLine());
            double secondCoefficient = Convert.ToDouble(Console.ReadLine());
            double thirdCoefficient = Convert.ToDouble(Console.ReadLine());


            (double,double) result = SquareEquation(firstCoefficient,secondCoefficient,thirdCoefficient);
            Console.WriteLine(result);

            string result2 = SquareEquatio2(ref firstCoefficient, ref secondCoefficient,ref thirdCoefficient);
            Console.WriteLine(result2);

        }
        /// <summary>
        /// returnes roots of square equation double type
        /// </summary>
        /// <param name="A">First coeficcient</param>
        /// <param name="B">Second coeficcient</param>
        /// <param name="C">Third coeficcient</param>
        /// <returns>returnes double numbers</returns>
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
        /// <summary>
        /// Returnes roots of equation with string value 
        /// </summary>
        /// <param name = "A" > First coeficcient</param>
        /// <param name="B">Second coeficcient</param>
        /// <param name="C">Third coeficcient</param>
        /// <returns>Returnes string value</returns>
        static string SquareEquatio2(ref double A,ref  double B, ref double C)
        {
            double root1 = -1;
            double root2 = -1;
            //A = 1; B = -5; C = 6; // if this line is active function uses this values for work

            double Diskr = Math.Pow(B, 2) - 4 * A * C;
            if (Diskr >= 0)
            {
                root1 = (-B + Math.Sqrt(Diskr)) / (2 * A);
                root2 = (-B - Math.Sqrt(Diskr)) / (2 * A);

            }

            if (root1 != root2)
                return ($"{root1}\t{root2} ");
            else
                return ($"{root1}");

        }


    }
}
