using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDiscriminant
{

    public class FirstClass
    {
        public int a;
        public int b;
        public int c;
        public double x;
        public double y;

        public FirstClass()
        {

        }
    }

    public class SimpleQuadraticEquation
    {


        public FirstClass GetSolution(int a,int b, int c)
        {
            FirstClass ob = new FirstClass();
       
                double discriminant = Math.Pow(b, 2) - 4 * c * a;

                if (discriminant > 0)
                {
                    ob.x = -b + Math.Sqrt(discriminant) / (2 * a);
                    ob.y = -b - Math.Sqrt(discriminant) / (2 * a);
                }
                else if (discriminant == 0)
                {
                    ob.x = -b / (2 * a);
                    ob.y = ob.x;
                }
                else
                {
                    ob.x = double.NaN;
                    ob.y = double.NaN;
                }

                return ob;
            }
        }
    }

