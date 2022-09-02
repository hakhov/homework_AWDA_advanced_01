using System;

namespace KeyBoardDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo button;
            do
            {
               
                button = Console.ReadKey();
                Console.WriteLine($"->You Pressed {button.Key}");

            } while (button.Key!=ConsoleKey.Escape);
            

        }
    }
}
