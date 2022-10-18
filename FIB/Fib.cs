using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIB
{
   public class Fib
    {
        public int CalcFib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else return CalcFib(n - 1) + CalcFib(n - 2);
          
           
        }
        
    }
   
}
