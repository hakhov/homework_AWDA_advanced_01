using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCarShop
{
    public class BuyingProcess
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
        public void Buy(int id)
        {
            var deletedCar = new Car();
            foreach (var car in allCars)
            {
                
                if (car.ID==id)
                {

                    deletedCar = car;
                    Console.WriteLine($"Congrats You bought {car.InfoDetails()}");
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
