using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Program
    {
        public static void Main()
        {
            StoreManager manager = new StoreManager();
            PrintService printer = new PrintService();
            Registration registration = new Registration();

            Store MyStore = new Store("Car Shop", "+37477802530", "Davtashen 9 str 51", 2365440);



            manager.Create(new Car("BMW", "E50", "Gray", 250, 2021, 09, 15, 39, 15000));
            manager.Create(new Car("BMW", "E60", "WHite", 280, 2022, 10, 25, 4, 21000));
            manager.Create(new Car("BMW", "X5", "Black", 240, 2020, 10, 25, 15, 16000));
            manager.Create(new Car("Mercedes", "C180", "Black", 250, 1998, 11, 28, 15, 5000));
            manager.Create(new Car("Mercedes", "GLA SUV", "Black", 420, 2022, 08, 28, 2, 36200));
            manager.Create(new Car("Mercedes", "E320", "White", 300, 2012, 11, 18, 5, 12000));
            manager.Create(new Car("Opel", "Vectra", "White", 150, 2000, 01, 08, 7, 3700));
            manager.Create(new Car("Opel", "Astra G", "Blue", 160, 2002, 01, 04, 12, 4200));
            manager.Create(new Car("Opel", "Zafira", "BLack", 165, 2008, 03, 08, 4, 4150));

            registration.CreateUser(new User("Caspeer", "Rood", 780000000));
            registration.CreateUser(new User("Carlos", "Alcaraz", 150000000));


            while (true)
            {
            repeat:
                Console.Clear();
                Console.WriteLine("Follow  the commands and press corresponding digits:\n" +
                    " 0. To Store\n 1. Show all list.\n 2. Show only 'BMW'\n 3. Show only 'Mercedes'\n 4. Show only 'Opel'\n 5 Exit");
                int output1 = Convert.ToInt32(Console.ReadLine());
                switch (output1)
                {
                    case 0:
                        goto store;
                    case 1:
                        Console.Clear();
                        printer.PrintAll(manager.GetAll());
                        break;
                    case 2:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("BMW"));
                        break;
                    case 3:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("Mercedes"));
                        break;
                    case 4:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("Opel"));
                        break;
                    case 5:
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong command!");
                        break;
                }
                Console.WriteLine("Press any key for next command!");
                Console.ReadLine();
            store:
                Console.Clear();
                Console.WriteLine("Follow  the commands and press corresponding digits to buy a car:\n" +
                    " 1. Buy 'BMW'\n 2. Buy 'Mercedes'\n 3. Buy 'Opel'\n 4. Back\n 5. Exit");
                int output2 = Convert.ToInt32(Console.ReadLine());
                switch (output2)
                {
                    case 1:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("BMW"));
                        break;
                    case 2:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("Mercedes"));
                        break;
                    case 3:
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByName("Opel"));
                        break;
                    case 4:
                        goto repeat;
                    case 5:
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong command!");
                        break;
                }
                Console.WriteLine("Press Enter  for next command!");
                Console.ReadLine();
                Console.WriteLine("Enter the model from suggested!");
                string output3 = Console.ReadLine();
                switch (output3.ToLower())
                {
                    case "e50":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "e60":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "x5":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "c180":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "gla suv":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "e320":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "vectra":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "astra g":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;
                    case "zafira":
                        Console.Clear();
                        printer.PrintAll(manager.GetAllByModel(output3));
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong command!");
                        goto repeat;
                }
                Console.WriteLine($"Your choise is \n{manager.GetByModel(output3).ToString()}\n_ _ _ _ _ _ _ _ _ _\n");
                Console.WriteLine(" Everything is ready!\n Enter your Name");
                string userName = Console.ReadLine();
                Console.WriteLine("Enter the count you want to by!");
                int count = Convert.ToInt32(Console.ReadLine());
                manager.Payment(userName, manager.GetByModel(output3), count);
                Console.ReadLine();

            }

            //Console.WriteLine("Create 3 types of cars!\n");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter the name of car!");
            //    String name = Console.ReadLine();
            //    Console.WriteLine("Enter the model of car!");
            //    String model = Console.ReadLine();
            //    Console.WriteLine("Enter the color of car!");
            //    String color = Console.ReadLine();
            //    Console.WriteLine("Enter the engine power of car!");
            //    int engPower = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the date of car production!");
            //    Console.WriteLine("Year");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Month");
            //    int month = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Day");
            //    int day = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter the count you want to product this car!");
            //    int count = Convert.ToInt32(Console.ReadLine());
            //    //Createing car
            //    manager.Create(new Car(name, model,color,engPower,year,month,day,count));
            //    Console.Clear();
            //}
            //print.PrintAll(manager.GetAll());
            //print.PrintCarInfo(manager.Get("BMW"));
        }


    }

}
