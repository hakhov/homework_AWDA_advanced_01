
    internal class Customer
    {
    public string Name { get; set; }
    public  decimal Money { get; set; }
    List<ICarProvider> mycars = new List<ICarProvider>();

    public Customer(string name)
    {
        Name = name;
        Money = 50000;
    }

    public void BuyCar()
    {

    }
}

