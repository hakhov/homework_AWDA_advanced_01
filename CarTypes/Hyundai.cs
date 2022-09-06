using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypes
{
    internal class Hyundai
    {
        public string CarName3 = "Hyundai";

        public void HyundaIType(string name,double pey)
        {   CarName3 = name;   
            var Hmodel1 = ("Accent SEL Sedan", "Red", "526 hp", 7, 34562, 19.300);
            var Hmodel2 = ("S-Class Sedan", "Green", "500 hp", 3, 34462, 20.500);
            var Hmodel3 = ("Mercedes-Maybach S-Class", "White", "570 hp", 3, 34552, 84.900);
            var Hmodel4 = ("E-Class Wegan", "Grow", "590 hp", 1, 34562, 65.400);
            if (pey >= Hmodel1.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Hmodel1.Item1);
                Console.WriteLine("Is the model color : " + Hmodel1.Item2);
                Console.WriteLine("Car engine power : " + Hmodel1.Item3);
                Console.WriteLine("the number of cars available : " + Hmodel1.Item4);
                Console.WriteLine("Is the model ID : " + Hmodel1.Item5);
            }

            if (pey >= Hmodel2.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Hmodel2.Item1);
                Console.WriteLine("Is the model color : " + Hmodel2.Item2);
                Console.WriteLine("Car engine power : " + Hmodel2.Item3);
                Console.WriteLine("the number of cars available : " + Hmodel2.Item4);
                Console.WriteLine("Is the model ID : " + Hmodel2.Item5);
            }

            if (pey >= Hmodel3.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Hmodel3.Item1);
                Console.WriteLine("Is the model color : " + Hmodel3.Item2);
                Console.WriteLine("Car engine power : " + Hmodel3.Item3);
                Console.WriteLine("the number of cars available : " + Hmodel3.Item4);
                Console.WriteLine("Is the model ID : " + Hmodel3.Item5);
            }
            if (pey >= Hmodel4.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Hmodel4.Item1);
                Console.WriteLine("Is the model color : " + Hmodel4.Item2);
                Console.WriteLine("Car engine power : " + Hmodel1.Item3);
                Console.WriteLine("the number of cars available : " + Hmodel4.Item4);
                Console.WriteLine("Is the model ID : " + Hmodel4.Item5);
            }
            else
                Console.WriteLine();
        }
    }
}
