using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Tuple_RefOut
{
    public class ClassMethods
    {
        //static Tuple<double, double> Discriminant_Tuple(double a, double b, double c)
        //{
        //    double disc = b * b - 4 * a * c;
        //    Tuple<double, double> result = new Tuple<double, double>(0, 0);          ////Why readonly???
        //    if (disc >= 0)
        //    {
        //        result.Item1 = (-b + Math.Sqrt(disc)) / 2 * a;

        //    }
        //}         

        public static (double, double) Discriminant_tuple(double a, double b, double c)
        {
            double disc = b * b - 4 * a * c;
            (double,double) result = (0, 0);
            if (disc >= 0)
            {
                result.Item1 = (-b + Math.Sqrt(disc)) / (2 * a);
                result.Item2 = (-b - Math.Sqrt(disc)) / (2 * a);

            }
            else
            {
                throw new Exception("Has no solution");
            }
            return result;
        }



        public static double Discriminant_Out(double a,double b,double c,out double solution2)
        {
            double disc = b * b - 4 * a * c;

            double solution1 = 0;
            if (disc >= 0)
            {
                solution1 = (-b + Math.Sqrt(disc)) / (2 * a);
                solution2 = (-b - Math.Sqrt(disc)) / (2 * a);

            }
            else
            {
                throw new Exception("Has no solution");
            }
            return solution1;
        }


        public static Solution SimpleSolution(double a,double b, double c)
        {
            double disc = b * b - 4 * a * c;
            Solution solution = new Solution(); 
            
            if (disc >= 0)
            {
                solution.Solution1 = (-b + Math.Sqrt(disc)) / (2 * a);
                solution.Solution2 = (-b - Math.Sqrt(disc)) / (2 * a);

            }
            else
            {
                throw new Exception("Has no solution");
            }
            return solution;
        }

    }
}
