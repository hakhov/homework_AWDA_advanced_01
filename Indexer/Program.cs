using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            TransProc transProc = new()
            {
                Arr = new[]
                {
                    new Words("red","Karmir"),
                    new Words("green","Kanach"),
                    new Words("blu","Kapuyt")
                }
            };
            Console.WriteLine(transProc["red"]  );
    }
}
}
