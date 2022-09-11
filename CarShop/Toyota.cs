using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop
{
    public class Toyota
    {
        public static void Model(int price)
        {

            (string, string, int, int) model1 = ("Corolla Cross 2022", "Celestite", 169, 22445);
            int quontity1 = 5;
            (string, string, int, int) model2 = ("HighLander 2022", "Midnight Black Metallic", 295, 39555);
            int quontity2 = 3;
            (string, string, int, int) model3 = ("GR Supra 2022", "Turbulence Grey", 255, 43540);
            int quontity3 = 1;
            string yesorno = "";

            if (price >= 22445 && price < 39555)
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
            else if (price >= 39555 && price < 43540)
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
            else if (price >= 43540)
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

