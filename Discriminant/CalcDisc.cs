using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminant
{
    class CalcDisc
    {
        double D;
        //double x1 = 0;
        //double x2 = 0;
        public (double,double) CalcDisc1(double a,double b, double c)
        {
            D = b * b - 4 * a * c;
            (double, double) k = (0, 0);
            if (D<0)
            {
                return k;
            }
            else if (D >= 0)
            {
                double  x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                k.Item2 = x2;
                k.Item1 = x1;
                return k;
            }
            else
            {
                double x0 = (-b) / 2 * a;
                k.Item2 = k.Item1 = x0;
                return k;
            }
        }
    }
}
