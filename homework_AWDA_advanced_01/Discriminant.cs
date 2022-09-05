using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_AWDA_advanced_01
{

        public class Discriminant
        {


            public void WithRef(int a, int b, int c, ref double x1, ref double x2)
            {

                if ((Math.Pow(b, 2) - 4 * a * c) >= 0)
                {
                    x1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                    x2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                }
                else
                {
                    Console.WriteLine("Empty sets");
                    return;
                }

            }

            public double[] WithoutRef(double a, double b, double c)
            {

                double[] arr = new double[2];
                double d = Math.Pow(b, 2) + (-4 * a * c);
                if (d >= 0)
                {
                    arr[0] = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                    arr[1] = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

                }
                else
                {
                    Console.WriteLine("Empty sets");

                }
                return arr;

            }


        }
    }



