
internal interface ICarShopProvider
{
    void OrderCar(ICarProvider car);
    ICarProvider SellCar(ICarProvider car);
    void ShowCars();
}

