using System;
using System.Collections.Generic;
using System.Text;

namespace CarsShop { 
    public class Mercedes_Benz
    {
        public static void Model(int price)
        {

            (string, string, int, int) model1 = ("GLC 300 4MATIC SUV", "Polar White", 255, 45850);
            int quontity1 = 5;
            (string, string, int, int) model2 = ("E-Class Coupe", "Selenite Gray Metallic", 362, 66100);
            int quontity2 = 3;
            (string, string, int, int) model3 = ("G-Class", "Obsidian Black Metallic", 416, 139900);
            int quontity3 = 1;
            string yesorno = "";

            if (price >= 45850 && price < 66100)
            {
                Console.WriteLine("We can offer you the model " + model1.Item1 + " : " + model1.Item2 + " color: "
                + model1.Item3 + " hp: Cost " + model1.Item4 + "$");
                Console.WriteLine("Do you want to buy?(yes/no)");
                yesorno = Convert.ToString(Console.ReadLine().ToLower());
                if (quontity1 > 0)
                {
                    if (yesorno == "yes")
                    {
                        Console.WriteLine("Congratulations, you bought the car");
                        quontity1--;
                    }
                    else if (yesorno == "no")
                    {
                        Console.WriteLine("You can choose another car");
                    }

                }
                else if (quontity1 == 0)
                {
                    Console.WriteLine("Sorry, this model is out of stock");
                }
            }
            else if (price >= 66100 && price < 139900)
            {
                Console.WriteLine("We can offer you the model " + model2.Item1 + " : " + model2.Item2 + " color: "
                + model2.Item3 + " hp: Cost " + model2.Item4 + "$");
                Console.WriteLine("Do you want to buy?(yes/no)");
                yesorno = Convert.ToString(Console.ReadLine().ToLower());
                if (quontity2 > 0)
                {
                    if (yesorno == "yes")
                    {
                        Console.WriteLine("Congratulations, you bought the car");
                        quontity2--;
                    }
                    else if (yesorno == "no")
                    {
                        Console.WriteLine("You can choose another car");
                    }

                }
                else if (quontity2 == 0)
                {
                    Console.WriteLine("Sorry, this model is out of stock");
                }
            }
            else if (price >= 139900)
            {
                Console.WriteLine("We can offer you the model " + model3.Item1 + " : " + model3.Item2 + " color: "
                + model3.Item3 + " hp: Cost " + model3.Item4 + "$");
                Console.WriteLine("Do you want to buy?(yes/no)");
                yesorno = Convert.ToString(Console.ReadLine().ToLower());

                if (quontity3 > 0)
                {

                    if (yesorno == "yes")
                    {
                        quontity3--;
                        Console.WriteLine("Congratulations, you bought the car");

                    }
                    else if (yesorno == "no")
                    {
                        Console.WriteLine("You can choose another car");
                    }

                }
                else if (quontity3 == 0)
                {
                    Console.WriteLine("Sorry, this model is out of stock");
                }
            }
            else
            {
                Console.WriteLine("Your moneyis not enought to buy cars of this brand. You can choose another brand");

            }
        }

    }
}

