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

            switch (choise)
            {
                case "1":
                case "Euro":
                    Console.Write("Enter car name correct (BMW or Mercedes-Benz): ");
                    string carname = Console.ReadLine();
                    return Euro_Cars.Bought_Car(carname);

                    break;
                case "2":
                case "Japan":
                    Console.Write("Enter car name correct (Toyota or Lexus): ");
                    string carname1 = Console.ReadLine();
                    return Japan_Cars.Bought_Car(carname1);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Wrong choise!!! Try again");
                    goto Error;
            }
        }



    }
}
