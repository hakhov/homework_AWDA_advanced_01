using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_withdelegate
{

    public delegate void MyDelegate<T>(T a, T b);
    public class MyClass
    {
        public void func<T>(T a, T b)
        {
            Console.WriteLine(a + " " + b);
        }
    }
}
