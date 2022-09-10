using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Car
    {
        public Guid Id { get; } = new Guid();
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int EngPower { get; set; }
        public DateTime DateOfProduction { get; set; }
        public int DefaultCount { get; set; }
        public int Price { get; set; }

        public Car()
        {

        }
        public Car(string name, string model, string color, int engPower, int year, int month, int day,int defCount,int price )
        {
            Name = name;
            Model = model;
            Color = color;
            EngPower = engPower;
            string date = String.Format($"{year}/{month}/{day}");
            DateOfProduction = DateTime.Parse(date);
            DefaultCount = defCount;
            Price = price;
        }
       
        public override string ToString()
        {
            return $"_ _ _ _ _ _ _ _ _ _ _ _ _ _\nCar:{Color} {Name} {Model}\n Engine Power: {EngPower} Hp\n" +
                 $"Price: {Price}\n_ _ _ _ _ _ _ _ _ _ _ _ _ _";
        }
    }
}
