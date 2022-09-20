using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NewCarShop.Constants;

namespace NewCarShop
{
    public static class Garage
    {
        public static List<Car> GetCars()
        {
            var cars = new List<Car>();

            cars.Add(new Car { Make = Make.Mazda, Name = "3", Color = Color.black, Price = 9500, Quantity = 2, ID = 1 });
            cars.Add(new Car { Make = Make.Mazda, Name = "3", Color = Color.red, Price = 9500, Quantity = 2, ID = 2 });
            cars.Add(new Car { Make = Make.Mazda, Name = "6", Color = Color.red, Price = 19500, Quantity = 2, ID = 3 });
            cars.Add(new Car { Make = Make.Mazda, Name = "6", Color = Color.white, Price = 19500, Quantity = 2, ID = 4 });
            cars.Add(new Car { Make = Make.Mazda, Name = "CX5", Color = Color.white, Price = 29500, Quantity = 3, ID = 5 });
            cars.Add(new Car { Make = Make.Mazda, Name = "CX5", Color = Color.black, Price = 29500, Quantity = 3, ID = 6 });
            cars.Add(new Car { Make = Make.Mazda, Name = "CX5", Color = Color.silver, Price = 29500, Quantity = 3, ID = 7 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "C Class", Color = Color.silver, Price = 9500, Quantity = 3, ID = 7 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "C Class", Color = Color.black, Price = 9500, Quantity = 3, ID = 8 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "C Class", Color = Color.red, Price = 9500, Quantity = 3, ID = 9 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "E Class", Color = Color.black, Price = 19500, Quantity = 2, ID = 10 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "E Class", Color = Color.white, Price = 19500, Quantity = 2, ID = 11 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "S Class", Color = Color.black, Price = 29500, Quantity = 3, ID = 12 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "S Class", Color = Color.black, Price = 29500, Quantity = 3, ID = 13 });
            cars.Add(new Car { Make = Make.Mercedes, Name = "S Class", Color = Color.silver, Price = 29500, Quantity = 3, ID = 14 });
            cars.Add(new Car { Make = Make.BMW, Name = "3 Generation", Color = Color.silver, Price = 9500, Quantity = 2, ID = 15 });
            cars.Add(new Car { Make = Make.BMW, Name = "3 Generation", Color = Color.white, Price = 9500, Quantity = 2, ID = 16 });
            cars.Add(new Car { Make = Make.BMW, Name = "5 Generation", Color = Color.red, Price = 19500, Quantity = 3, ID = 17});
            cars.Add(new Car { Make = Make.BMW, Name = "5 Generation", Color = Color.black, Price = 19500, Quantity = 3, ID = 18 });
            cars.Add(new Car { Make = Make.BMW, Name = "5 Generation", Color = Color.silver, Price = 19500, Quantity = 3, ID = 19 });
            cars.Add(new Car { Make = Make.BMW, Name = "7 Generation", Color = Color.black, Price = 29500, Quantity = 2, ID = 20 });
            cars.Add(new Car { Make = Make.BMW, Name = "7 Generation", Color = Color.white, Price = 29500, Quantity = 2, ID = 21 });
            return cars;
        }
    }
}
