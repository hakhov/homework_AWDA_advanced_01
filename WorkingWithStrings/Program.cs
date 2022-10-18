using System;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "sample";
            string x1 = "sample";
            string x2 = x;
            Console.WriteLine(x.Equals(x2)); 
            Console.WriteLine(x.Equals(x1));
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(x1.GetHashCode()); 
            Console.WriteLine(x2.GetHashCode());
            Console.WriteLine(ReferenceEquals(x,x1));
            Console.WriteLine(x.CompareTo(x2)); 
        }
    }
}
