﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantWithRef
{
    class Calc
    {
        double D;
        
        public void CalcDisc1(double a, double b, double c, ref double x1, ref double x2)
        {
            D = b * b - 4 * a * c;
            (double, double) k = (0, 0);
            if (D < 0)
            {
                Console.WriteLine("there is no solution"); ;
            }
            else if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                k.Item2 = x2;
                k.Item1 = x1;

            }
            else
            {
                double x0 = (-b) / 2 * a;
                k.Item2 = k.Item1 = x0;
                Console.WriteLine("");
            }
        }
    }
}