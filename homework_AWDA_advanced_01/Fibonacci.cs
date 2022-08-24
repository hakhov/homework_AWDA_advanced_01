using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_AWDA_advanced_01
{
    internal class Fibonacci
    {
       
        public static int FibonacciMethod(int num, int first=0, int second=1)
        {
            if (second>=num)
            {
                return first;
            }
            Console.Write(first+", ");
            return FibonacciMethod(num,  second, first + second);
        }


    }
}
