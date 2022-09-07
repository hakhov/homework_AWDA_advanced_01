namespace CarShop
{
    internal class Car
    {
        private static int id_generator = 1000;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Model { get; private set; }
        public Color _Color { get; private set; }
        public double Engine { get; private set; }
        public decimal Price { get; private set; }

        public Car(string name, string model, Color color, double engine, decimal price)
        {
            Id = id_generator++;
            Name = name;
            Model = model;
            _Color = color;
            Engine = engine;
            Price = price;
        }

        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Name: {Name}\tModel: {Model}\tEngine: {Engine}\t" +
                $"Color: {_Color}\tPrice: {Price} $\tId: {Id}");
            Console.WriteLine("---------------------------------------------------");

        }

    }
}
