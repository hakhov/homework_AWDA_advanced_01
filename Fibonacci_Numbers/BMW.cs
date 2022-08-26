using Example_Protected_Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    public class BMW:Car
    {
        public void Wrtie_fromBMW()
        {
            Console.WriteLine($"Here I can use quality its: {quality}");
        }
    }
}
