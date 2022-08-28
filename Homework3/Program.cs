using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            ConsoleKeyInfo info = new ConsoleKeyInfo();
            info = Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine($"You pressed the key {info.Key}");
        }
    }
}
