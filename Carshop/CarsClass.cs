using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carshop
{
    class CarsClass
    {

        public decimal money;
            
        public (decimal, string) ReturnAnswerByMoney(decimal Money, string make)
        {
            //if (money<9500)
            //{
            //    Console.WriteLine("SORRY YOU DON'T HAVE ENOUGH MONEY");
            //    return (0, null);
            //}
            money = Money;
            string make1 = make;
            if (Money < 19500)
            {
                if (make1 == "mazda")
                {
                    Console.WriteLine("You can buy only Mazda 3");
                    Console.WriteLine("Do You wanna buy? Y/N ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        return (9500, "mazda");
                    }
                    if (Console.ReadLine() == "N")
                    {
                        return (0, null);
                    }

                }
                else
                {
                    Console.WriteLine("You can buy only Mercedes C class");
                    Console.WriteLine("Do You wanna buy? Y/N ");
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        return (9500, "mercedes");
                    }
                    if (Console.ReadLine() == "N")
                    {
                        return (0, null);
                    }
                }

            }
            else if (19500 <= Money && Money < 29500)
            {
                if (make1 == "mazda")
                {
                    Console.WriteLine("You can buy only Mazda 3(0) and Mazda 6(1)");
                    Console.WriteLine("What do You wanna Buy ? ");
                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        return (9500, "mazda");
                    }
                    else
                    {
                        return (19500, "mazda");
                    }

                }
                else
                {
                    Console.WriteLine("You can buy only Mercedes C Class(0) and E Class(1))");
                    Console.WriteLine("What do You wanna Buy ?");
                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        return (9500, "mercedes");
                    }
                    else
                    {
                        return (19500, "mercedes");
                    }
                }
            }
            else
            {
                if (make1 == "mazda")
                {
                    Console.WriteLine("You can buy only Mazda 3(0), Mazda 6(1) or Mazda RX8(2)");
                    Console.WriteLine("What do You wanna Buy ?");
                    var isInt = int.TryParse(Console.ReadLine(),out int result);
                    if (isInt)
                    {
                        switch (result)
                        {
                            case 0:
                                return (9500, "mazda");
                            case 1:
                                return (19500, "mazda");
                            case 2:
                                return (29500, "mazda");

                       }
                    }
                    else
                    {
                        Console.WriteLine("Input correct digit!!!");
                    }
                  

                }
                else
                {
                    Console.WriteLine("You can buy  Mercedes C Class(0) , E Class(1) or S Class)");

                    Console.WriteLine("What do You wanna Buy ? ");
                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        return (9500, "mercedes");
                    }
                    else if (int.Parse(Console.ReadLine()) == 1)
                    {
                        return (19500, "mercedes");
                    }
                    else
                    {
                        return (29500, "mercedes");
                    }
                }

            }
            return (0, null);
        }
        public decimal BuyingProcess(string name, decimal price)
        {
            switch (name)
            {
                case "mazda":
                    BuyMazda obj = new();
                    if (price == 9500)
                    {
                        
                        Console.WriteLine("Congrats You have bought Mazda 3");
                        Console.WriteLine($"You have only ${money-9500}");
                        return money - 9500;
                    }
                    else if (price == 19500)
                    {
                        obj.Mazda6();
                        Console.WriteLine("Congrats You have bought Mazda 6");
                        Console.WriteLine($"You have only ${money - 19500}");
                        return money - 19500;
                    }
                    else
                    {
                        obj.MazdaRX8();
                        Console.WriteLine("Congrats You have bought Mazda RX8");
                        Console.WriteLine($"You have only ${money - 29500}");
                        return money - 29500;
                    }
                case "mercedes":
                    BuyMerc obj1 = new();
                    if (price == 9500)
                    {
                        obj1.MercedesC();
                        Console.WriteLine("Congrats You have bought Mercedes C Class");
                        Console.WriteLine($"You have only ${money - 9500}");
                        return money - 9500;
                    }
                    else if (price == 19500)
                    {
                        obj1.MercedesE();
                        Console.WriteLine("Congrats You have bought Mercedes E Class");
                        Console.WriteLine($"You have only ${money - 19500}");
                        return money - 19500;
                    }
                    else
                    {
                        obj1.MercedesS();
                        
                        Console.WriteLine("Congrats You have bought Mercedes S Class");
                        Console.WriteLine($"You have only ${money - 29500}");
                        return money - 29500;
                    }
                    break;

            }
            return money;
        }

        internal class BuyMazda
        {

            string make = "mazda";
            string price;
            public void Mazda3(ref int quantity)
            {
                quantity = 4;
                quantity--;
                string name = "MAZDA 3";
                decimal Price = 9500;
                string color = "Black";
                int HP = 167;
                int ID = 1;
              

            }
            public void Mazda6()
            {
                int quantity = 5;
                string name = "MAZDA 6";
                decimal Price = 19500;
                string color = "Black";
                int HP = 192;
                int ID = 2;

            }
            public void MazdaRX8()
            {
                int quantity = 2;
                string name = "MAZDA RX8";
                decimal Price = 29500;
                string color = "Black";
                int HP = 267;
                int ID = 3;
                Console.WriteLine();
            }


            public void Show()
            {
                Console.WriteLine($"Congrats You have bought {make}");
            }
        }
        internal class BuyMerc
        {
            string make = "mercedes";
            public void MercedesC()
            {
                int quantity = 5;
                string name = "Mercedes Benz C class";
                decimal Price = 9500;
                string color = "Black";
                int HP = 267;
                int ID = 4;
            }
            public void MercedesE()
            {
                int quantity = 4;
                string name = "Mercedes Benz E class";
                decimal Price = 29500;
                string color = "Black";
                int HP = 267;
                int ID = 5;
            }
            public void MercedesS()
            {
                int quantity = 3;
                string name = "Mercedes Benz S class";
                decimal Price = 29500;
                string color = "Black";
                int HP = 267;
                int ID = 6;
            }


            public void Show()
            {
                Console.WriteLine($"Congrats You have bought {make}");
            }
        }
    }

}





