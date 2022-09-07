namespace CarShop
{
    internal class Car_Shop
    {
        public string Name { get; private set; }
        private List<Model_Info> allCars;

        public Car_Shop(string name)
        {
            Name = name;
            allCars = new List<Model_Info>();
        }

        public void Order_Car(int count, string name, string model, Color color, double engine, decimal price)
        {
            allCars.Add(new Model_Info(count, new Car(name, model, color, engine, price)));
        }

        private Model_Info ChoosenCar(string name)
        {
            var cars = from car in allCars
                       where car.Count > 0 && (car._Car.Name == name)
                       orderby car._Car.Price
                       select car;

            foreach (var car in cars)
            {
                car._Car.GetInfo();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

        ERROR1: Console.Write("\nSelect the car Id which you want to buy: ");
            int id = int.Parse(Console.ReadLine());

            var choosen_car = from car in cars
                              where car._Car.Id == id
                              select car;
            Model_Info model_Info = choosen_car.FirstOrDefault();

            if (model_Info == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Oops,choose right Id");
                goto ERROR1;
            }
            else
            {

                allCars.Remove(model_Info);
                model_Info.Count--;
                allCars.Add(model_Info);

                return model_Info;
            }
        }
        private Model_Info ChoosenCar(decimal price)
        {
            var cars = from car in allCars
                       where car.Count > 0 && (car._Car.Price <= price)
                       orderby car._Car.Price
                       select car;

            foreach (var car in cars)
            {
                car._Car.GetInfo();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;

        ERROR1: Console.Write("\nSelect the car Id which you want to buy: ");
            int id = int.Parse(Console.ReadLine());

            var choosen_car = from car in cars
                              where car._Car.Id == id
                              select car;
            Model_Info model_Info = choosen_car.FirstOrDefault();

            if (model_Info == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Oops,choose right Id");
                goto ERROR1;
            }
            else
            {

                allCars.Remove(model_Info);
                model_Info.Count--;
                allCars.Add(model_Info);

                return model_Info;
            }
        }

        public Car Bought_Car(string name)
        {
            Model_Info model_Info = ChoosenCar(name);
            return model_Info._Car;
        }
        public Car Bought_Car(decimal price)
        {
            Model_Info model_Info = ChoosenCar(price);
            return model_Info._Car;
        }
    }
}
