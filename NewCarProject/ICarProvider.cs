
    internal interface ICarProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public ConsoleColor Color { get; set; }
        public double Engine { get; set; }
    }

