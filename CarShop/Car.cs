using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop
{
    public class Car
    {
        private string CarBrand;
        private int CarPrice;

        public Car(string brand, int price)
        {
            CarBrand = brand;
            CarPrice = price;
        }
        public Car()
        {
        }
        public void BrandName()
        {
            string brand = CarBrand;
            int price = CarPrice;
            if (brand == "Mercedes-Benz")
            {
                CarShop.Mercedes_Benz.Model(price);
            }

            if (brand == "Toyota")
            {
                CarShop.Toyota.Model(price);
            }
            if (brand == "Porsche")
            {
               CarShop.Porsche.Model(price);
            }
            else
            {
                Console.WriteLine("Brandy bacakayum e ");
            }
        }

    }
}