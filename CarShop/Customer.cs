namespace CarShop
{
    internal class Customer
    {
        public string Name { get; private set; }
        private List<Car> myCars;

        public Customer(string name)
        {
            Name = name;
            myCars = new List<Car>();
        }

        private void BuyCar()
        {
            Car car = Method.BuyCar(); Console.WriteLine("\n");

            car.GetInfo();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Do you want to buy this car(yes or no): ");
            string accept = Console.ReadLine();
            if (accept == "yes")
            {
                myCars.Add(car);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Congrats, you bought this car");
                car.GetInfo();
                Thread.Sleep(2000);
            }
            else return;

        }


        private void Show_Cars()
        {
            foreach (var car in myCars)
            {
                car.GetInfo();
            }
            Console.Write("Enter to continue: ");
            Console.ReadKey();
        }


        public void MyActions()
        {
            string choise;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1.My Cars 2.Buy new car 3.Close : ");
                choise = Console.ReadLine();
                Console.WriteLine();
                switch (choise)
                {
                    case "1":
                    case "My Cars":
                        Show_Cars();
                        break;
                    case "2":
                    case "Buy new car":
                        BuyCar();
                        break;
                    case "3":
                    case "Close":
                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("Thank you for using our application, Bye))))");
                        return;
                    default:
                        break;
                }

            }
        }
    }
}
