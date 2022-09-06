using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypes
{
    public class Mercedes_Benz
    {
        public string CarName1 = "Mercedes";

        public void MercedesBenzType(string name,double pey)
        {
            CarName1 = name;
            var model1 = ("EQS Sedan", "Red", "626 hp", 7, 14562,102.310);
            var model2 = ("S-Class Sedan", "Green", "600 hp", 5, 14462,111.100);
            var model3 = ("Mercedes-Maybach S-Class", "White", "670 hp", 3, 14552,184.900);
            var model4 = ("E-Class Wegan", "Grow", "590 hp", 7, 14562,68.400);
            var model5 = ("E-Class Cambriolet", "Black", "670 hp", 4, 11562, 73.250);
            var model6 = ("SL Roadster", "yellow", "660 hp", 2, 14561,137.400);
            if (pey >= model1.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model1.Item1);
                Console.WriteLine("Is the model color : " + model1.Item2);
                Console.WriteLine("Car engine power : " + model1.Item3);
                Console.WriteLine("the number of cars available : " + model1.Item4);
                Console.WriteLine("Is the model ID : " + model1.Item5);
            }

            if (pey >= model2.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model2.Item1);
                Console.WriteLine("Is the model color : " + model2.Item2);
                Console.WriteLine("Car engine power : " + model2.Item3);
                Console.WriteLine("the number of cars available : " + model2.Item4);
                Console.WriteLine("Is the model ID : " + model2.Item5); }

            if (pey >= model3.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model3.Item1);
                Console.WriteLine("Is the model color : " + model3.Item2);
                Console.WriteLine("Car engine power : " + model3.Item3);
                Console.WriteLine("the number of cars available : " + model3.Item4);
                Console.WriteLine("Is the model ID : " + model3.Item5);
            }
            if (pey >= model4.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model4.Item1);
                Console.WriteLine("Is the model color : " + model4.Item2);
                Console.WriteLine("Car engine power : " + model1.Item3);
                Console.WriteLine("the number of cars available : " + model4.Item4);
                Console.WriteLine("Is the model ID : " + model4.Item5);
            }
            if (pey >= model5.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model5.Item1);
                Console.WriteLine("Is the model color : " + model5.Item2);
                Console.WriteLine("Car engine power : " + model5.Item3);
                Console.WriteLine("the number of cars available : " + model5.Item4);
                Console.WriteLine("Is the model ID : " + model5.Item5);
            }
            if (pey >= model6.Item6)
            { 
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + model6.Item1);
                Console.WriteLine("Is the model color : " + model6.Item2);
                Console.WriteLine("Car engine power : " + model6.Item3);
                Console.WriteLine("the number of cars available : " + model6.Item4);
                Console.WriteLine("Is the model ID : " + model6.Item5);
            }
            else
            Console.WriteLine();
            }

        }
    }