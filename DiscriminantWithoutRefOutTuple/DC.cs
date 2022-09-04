using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscriminantWithoutRefOutTuple
{
    public class DC
    {
        public string answer;
        private double dis;
        public string MyDiscriminant(double a,double b,double c)
        {
            dis = b * b - 4 * a * c;
            if(dis < 0)
            {
                return answer;
            }
            else 
            if(dis>=0)
            {
               double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
               double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                answer = "Answer\n";
                answer += x1.ToString() + "\t" + x1.ToString();
                return answer;
            }
        }
    }
}
