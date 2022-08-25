using System;

namespace WithNew
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            ClassB b1 = new ClassB();
            ClassB b2 = new ClassA().FunctionA();
            int y = new ClassA().FunctionA().FunctionB1();
            Console.WriteLine(y);
        }
    }
}
