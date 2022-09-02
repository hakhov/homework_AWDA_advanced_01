using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantWithStandard
{
    class CalcWithStandard
    {
        double D;
        //double x1 = 0;
        //double x2 = 0;
        public Result CalcDisc1(double a, double b, double c)
        {
            var result = new Result();
            D = b * b - 4 * a * c;
            
            if (D < 0)
            {
                
                return  result;
            }
            else if (D >= 0)
            {
                result.x1 = (-b + Math.Sqrt(D)) / 2 * a;
                result.x2 = (-b - Math.Sqrt(D)) / 2 * a;
              
                return result;
            }
            else
            {
                result.x1=result.x2= (-b) / 2 * a;
               
                return result;
            }
        }

    }
    public class Result
    {
       public double x1 = 0;
       public double x2 = 0;
    }
}




