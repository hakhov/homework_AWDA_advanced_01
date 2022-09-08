using System;

namespace NewCarShop
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Which Make of car do You want? MERCEDES BENZ, BMW OR MAZDA");
                string make = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("How much Money do You Have?");
                decimal money = decimal.Parse(Console.ReadLine());
                var buyProc = new BuyingProcess();
                var cars = new BuyingProcess().AvailableCars(money, make);
                Console.WriteLine("You can buy ->");
                foreach (var car in cars)
                {
                    Console.Write(car.InfoDetails());
                    Console.WriteLine();
                }
                Console.WriteLine("Which one do You want?");
                Console.WriteLine("Please insert the ID");

                var id = int.TryParse(Console.ReadLine(), out int id1);
                buyProc.Buy(id1);
            } while (Console.ReadLine().ToLower() != "close");
           
        }
    }
}
