using System;

namespace Carshop
{
    class Program
    {
        static void Main(string[] args)
        {
            do {      
            Console.WriteLine("Which Make of car do You want? MAZDA or MERCEDES BENZ");
            string Make = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine("How much Money do You Have?");
            decimal Money = decimal.Parse(Console.ReadLine());
            CarsClass offer = new();
            (decimal, string) k = offer.ReturnAnswerByMoney(Money, Make);
            offer.BuyingProcess(k.Item2,k.Item1);
            } 
            while (Console.ReadLine().ToLower()!="close");


        }
    }
}
