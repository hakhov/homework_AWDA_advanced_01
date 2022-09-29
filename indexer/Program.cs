using System;

namespace _03_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User hakob = new User();
            hakob["id"] = "2000";
            hakob["name"] = "Hakob";
            hakob["email"] = "hakhov@gmail.com";

            Console.WriteLine(hakob["id"]);
            Console.WriteLine(hakob["name"]);
            Console.WriteLine(hakob["email"]);
            Console.WriteLine(hakob["eml"]);
        }
    }
}
