
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

internal class Mercedes_Benz_Shop : ICarShopProvider
{
    decimal money = 100000;
    private List<Mercedes_Benz> cars = new List<Mercedes_Benz>();
    public Mercedes_Benz_Shop()
    {
        cars = new List<Mercedes_Benz>();
    }
    public void OrderCar(ICarProvider benz)
    {
        Mercedes_Benz mercedes_Benz = (Mercedes_Benz)benz;
        money -= mercedes_Benz.Price;
        cars.Add(mercedes_Benz);
    }
   

    public ICarProvider SellCar(ICarProvider benz)
    {
        Mercedes_Benz mercedes_Benz = (Mercedes_Benz)benz;
        var _car = from car in this.cars
                  where car == mercedes_Benz
                  select car;
        money += mercedes_Benz.Price;
        return (ICarProvider)_car;
    }  

    public void ShowCars()
    {
        foreach (var item in cars)
        {
            item.ToString();
        }
    }

   
}

