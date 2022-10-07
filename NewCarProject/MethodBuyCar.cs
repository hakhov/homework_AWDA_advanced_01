
static class MethodBuyCar
{
    static Mercedes_Benz_Shop mercedes = new Mercedes_Benz_Shop();

    public static ICarProvider BuyCar()
    {
        Console.WriteLine("Choose shop");
        Console.WriteLine("1.Mercedes-Benz");
        string chiose = Console.ReadLine();
        switch (chiose)
        {
            case "1":
            case "Mercedes-Benz":
                mercedes.ShowCars();

                break;
            default:
                break;
        }
    }


}

