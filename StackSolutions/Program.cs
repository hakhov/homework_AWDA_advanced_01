using System;

namespace StackSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "{}[[)()(]]";
            MyClass myClass = new();
            myClass.isCompleted(sequence);
            Console.WriteLine();
        }
    }
}
