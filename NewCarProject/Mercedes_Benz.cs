
class Mercedes_Benz : ICarProvider
{  

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public ConsoleColor Color { get; set; }
    public double Engine { get; set; }

    public Mercedes_Benz(string name, string model, decimal price, ConsoleColor color, double engine)
    {
        Id = Guid.NewGuid();
        Name = name;
        Model = model;
        Price = price;
        Color = color;
        Engine = engine;
    }
    public override string ToString()
    {
        return $"Name:{Name}\tModel:{Model}\tEngine:{Engine}\tColor:{Color}\tPrice:{Price}Id:{Id}";
    }
}