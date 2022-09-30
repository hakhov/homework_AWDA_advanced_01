using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCarShop
{
    public class BuyingProcess : BuyAction
    {
        private static List<Car> allCars = Garage.GetCars();

        public List<Car> AvailableCars(decimal price, string make)
        {
            var result = new List<Car>();
            foreach (var car in allCars)
            {
                if (car.Make.ToString().ToLower().Contains(make) && car.Price <= price)
                {
                    result.Add(car);
                }
            }
            return result;
        }
        public override void Buy(int id, List <Car> cars)
        {
            var deletedCar = new Car();
            var x = cars;
            foreach (var car in cars)
            {

                if (car.ID == id)
                {

                    deletedCar = car;
                    Console.WriteLine($"Congrats You bought {car.ToString()}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please insert Correct Id");
                    break;
                }

                }
                allCars.Remove(deletedCar);
            foreach (var item in allCars)
            {
                if (item.Name==deletedCar.Name && item.Make==deletedCar.Make)
                {
                    item.Quantity--;
                }
            }
        }
    }
}
