using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class StoreManager
    {
        private static List<Car> CarList = new List<Car>();
        Store store = new Store();
        Registration registration = new Registration();

        public void Create(Car car)
        {
            CarList.Add(car);
        }

        public Car Get(string name)
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].Name.ToLower() == name.ToLower())
                    return CarList[i];
            }
            return default(Car);
        }
        public Car GetByModel(string model)
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].Model.ToLower() == model.ToLower())
                    return CarList[i];
            }
            return default(Car);
        }

        public List<Car> GetAll()
        {
            return CarList;
        }
        public List<Car> GetAllByName(string name)
        {
            List<Car> ListByName = new List<Car>();
            foreach (Car item in CarList)
            {
                if(item.Name == name)
                {
                    ListByName.Add(item);
                }
            }
            if (ListByName.Count > 0)
                return ListByName;
            else
            {
                Console.WriteLine("Wrong selection!");
                return CarList;
            }
        }
        public List<Car> GetAllByModel(string model)
        {
            List<Car> ListByModel = new List<Car>();
            foreach (Car item in CarList)
            {
                if (item.Model.ToLower() == model.ToLower())
                {
                    ListByModel.Add(item);
                }
            }
            if (ListByModel.Count > 0)
                return ListByModel;
            else
                return CarList;
        }

        public void Remove(Car car)
        {
            CarList.Remove(car);
        }

        public void Update(Car car)
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].Id == car.Id)
                {
                    CarList[i] = car;
                }
            }
        }

        public void Payment(string userName,Car car  , int count)
        {
            User myUser;
            if (registration.GetUser(userName) != null)
            {
                myUser = registration.GetUser(userName);
            }
            else
            {
                Console.WriteLine("User is not registrated!");
                return;
            }

            if (count > 0 && count <=car.DefaultCount)
            {
                car.DefaultCount -= count;
            }
            else if (count > car.DefaultCount)
            {
                Console.WriteLine($"We have only {car.DefaultCount} cars in store!\nPress Enter to try again!");
                return;
            }
            else
            {
                Console.WriteLine("That car is unavialable at this moment!");
                return;
            }

            store.Budget += count * car.Price;
            myUser.Pay(car.Price * count,registration.GetUser(userName));
            Console.WriteLine($"Budget is repaired by '$'{count * car.Price}!");
        }


    }
}
