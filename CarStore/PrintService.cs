using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class PrintService  //not public ?
    {
        public void PrintCarInfo(Car car)
        {
            Console.WriteLine($"Name: {car.Name}\nModel: {car.Model}\n"+$"Color: {car.Color}\n" + 
                $"Engine power: {car.EngPower}hp\n"+
                $"Date of production: {car.DateOfProduction}\n"+ $"Available count: {car.DefaultCount}");
        }
        public void PrintAll(List<Car> _cars)
        {
            for (int i = 0; i < _cars.Count; i++)
            {
                PrintCarInfo(_cars[i]);
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ ");
            }
        }
    }
}
