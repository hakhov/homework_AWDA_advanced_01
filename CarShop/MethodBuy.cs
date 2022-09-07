namespace CarShop
{
    internal class Method
    {
        private static Car_Shop Euro_Cars = ShopGenerator.Generate_EuroCars();
        private static Car_Shop Japan_Cars = ShopGenerator.Generate_JapanCars();

        public static Car BuyCar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi,Please choose motors\n");
        Error: Console.ForegroundColor = ConsoleColor.Yellow;


            Console.Write("1.Euro 2.Japan: ");
            string choise = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose car by 1.Name 2.Price  :");
            string chooseby = Console.ReadLine();

            switch (choise)
            {
                case "1":
                case "Euro":
                    if (chooseby == "1" || chooseby == "Name")
                    {
                        Console.Write("Enter car name correct (BMW, Mercedes-Benz, Audi): ");
                        string carname = Console.ReadLine();
                        return Euro_Cars.Bought_Car(carname);
                    }
                    else
                    {
                        Console.Write("Enter Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        return Euro_Cars.Bought_Car(price);
                    }


                    break;
                case "2":
                case "Japan":

                    if (chooseby == "1" || chooseby == "Name")
                    {
                        Console.Write("Enter car name correct (Toyota, Lexus, Nissan): ");
                        string carname1 = Console.ReadLine();
                        return Japan_Cars.Bought_Car(carname1);
                    }
                    else
                    {
                        Console.Write("Enter Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        return Japan_Cars.Bought_Car(price);
                    }
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong choise!!! Try again");
                    goto Error;
            }
        }



    }
}
