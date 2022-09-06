using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTypes
{
    internal class BMW
    {

        public string CarName2 = "BMW";

        public void BMWType(string name,double pey)
        {
            CarName2 = name;
            var Bmodel1 = ("BMW X4", "Red", "620 hp", 7, 24562, 104.310);
            var Bmodel2 = ("BMW X7", "Green", "650 hp", 5, 24462, 117.000);
            var Bmodel3 = ("BMW 4", "White", "670 hp", 5, 24552, 51.900);
            var Bmodel4 = ("BMW 7", "Grow", "620 hp", 3, 24562, 93.400 );
            var Bmodel5 = ("BMW Z4", "Black", "670 hp", 4, 21562, 53.250 );
            if (pey >= Bmodel1.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Bmodel1.Item1);
                Console.WriteLine("Is the model color : " + Bmodel1.Item2);
                Console.WriteLine("Car engine power : " + Bmodel1.Item3);
                Console.WriteLine("the number of cars available : " + Bmodel1.Item4);
                Console.WriteLine("Is the model ID : " + Bmodel1.Item5);
            }

            if (pey >= Bmodel2.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Bmodel2.Item1);
                Console.WriteLine("Is the model color : " + Bmodel2.Item2);
                Console.WriteLine("Car engine power : " + Bmodel2.Item3);
                Console.WriteLine("the number of cars available : " + Bmodel2.Item4);
                Console.WriteLine("Is the model ID : " + Bmodel2.Item5);
            }

            if (pey >= Bmodel3.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Bmodel3.Item1);
                Console.WriteLine("Is the model color : " + Bmodel3.Item2);
                Console.WriteLine("Car engine power : " + Bmodel3.Item3);
                Console.WriteLine("the number of cars available : " + Bmodel3.Item4);
                Console.WriteLine("Is the model ID : " + Bmodel3.Item5);
            }
            if (pey >= Bmodel4.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Bmodel4.Item1);
                Console.WriteLine("Is the model color : " + Bmodel4.Item2);
                Console.WriteLine("Car engine power : " + Bmodel1.Item3);
                Console.WriteLine("the number of cars available : " + Bmodel4.Item4);
                Console.WriteLine("Is the model ID : " + Bmodel4.Item5);
            }
            if (pey >= Bmodel5.Item6)
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Is the model name : " + Bmodel5.Item1);
                Console.WriteLine("Is the model color : " + Bmodel5.Item2);
                Console.WriteLine("Car engine power : " + Bmodel5.Item3);
                Console.WriteLine("the number of cars available : " + Bmodel5.Item4);
                Console.WriteLine("Is the model ID : " + Bmodel5.Item5);
            }
            else
                Console.WriteLine();
        }
    }
}
