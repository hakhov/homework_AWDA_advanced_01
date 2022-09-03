using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantWithRef
{
    public class MyDC
    {    double Dc;
        public void Discriminant(Tuple<double,double,double> members, ref double x1,ref double x2)
        {
            Dc = members.Item2*members.Item2 - 4 * members.Item1 * members.Item3;
            if (Dc < 0)
            { Console.WriteLine("Answer\nHas no root"); }
            else if(Dc >= 0)
            {
                x1 = (-members.Item2 + Math.Sqrt(Dc)) / (2 * members.Item1);
                x2 = (-members.Item2 - Math.Sqrt(Dc)) / (2 * members.Item1);
                Console.WriteLine($"Answer\nx1 = {x1}\nx2 = {x2}");
            }
        }
    }
}
