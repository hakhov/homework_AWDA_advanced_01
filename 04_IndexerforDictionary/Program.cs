using System;

namespace _04_IndexerforDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary()
            {
                Arr = new[]
                {
                    new Words("red", "Karmir"),
                    new Words("green", "Kanach"),
                    new Words("blue", "Kapuyn"),
                }
            };
            Console.WriteLine(dictionary["red"]);

            dictionary["blue"] = "Kapuy1n";
            Console.WriteLine(dictionary["blue"]);

        }
    }
}
