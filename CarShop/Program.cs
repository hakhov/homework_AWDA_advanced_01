using System;

namespace CarShop
{
    class Program
    {
        public static void Main(string[] args)
        {
            string close = "";
            //(int, int, int) quontity = (5, 2, 1);
            while (close != "close")
            {
                Console.WriteLine("Input the brand of Car -------Mercedes-Benz, Toyota, Porsche");
                string brand = Convert.ToString(Console.ReadLine());

                Console.WriteLine("How much money do you have?");
                int price = Convert.ToInt32(Console.ReadLine());

                Car car = new Car(brand, price);
                car.BrandName();
                Console.WriteLine("");
                Console.WriteLine("Click Enter to buy another model");
                Console.WriteLine("Type close to close");
                close = Convert.ToString(Console.ReadLine().ToLower());
                Console.WriteLine("");
            }

        }
    }
}
