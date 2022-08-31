using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    partial class Program
    {
        static int Fibonacci(int a)
        {
            if (a == 1 || a == 2)
            {
                return 1;
            }

            return Fibonacci(a - 1) + Fibonacci(a - 2);
        }
    }
