using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyPress
{
    public delegate void Printing();
    public class Print
    {
        public static void PrintA()
        {
            Console.WriteLine("A");
        }
        public static void PrintB()
        {
            Console.WriteLine("B");
        }
        public static void PrintC()
        {
            Console.WriteLine("C");
        }
    }
}
