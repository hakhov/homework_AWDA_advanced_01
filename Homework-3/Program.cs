using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Press any key");
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            key = Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine($"You pressed the key {key.Key}");

        }
    }
}
