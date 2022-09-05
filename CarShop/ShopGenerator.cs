namespace CarShop
{
    internal class ShopGenerator
    {
        public static Car_Shop Generate_EuroCars()
        {
            Car_Shop carShop = new Car_Shop("EuroCars");
            carShop.Order_Car(5, "Mercedes-Benz", "Cls", "White", 5.5, 38000);
            carShop.Order_Car(5, "Mercedes-Benz", "Cls", "Black", 6.3, 44000);
            carShop.Order_Car(3, "Mercedes-Benz", "Gle", "Black", 4.0, 48000);
            carShop.Order_Car(5, "Mercedes-Benz", "S", "White", 5.0, 52000);
            carShop.Order_Car(4, "BMW", "X6", "Blue", 6.0, 64000);
            carShop.Order_Car(4, "BMW", "F30", "White", 3.5, 31000);
            carShop.Order_Car(5, "BMW", "E60", "Gray", 3.0, 24000);
            carShop.Order_Car(5, "BMW", "E60", "White", 3.0, 24000);

            return carShop;
        }

        public static Car_Shop Generate_JapanCars()
        {
            Car_Shop carShop = new Car_Shop("JapanCars");
            carShop.Order_Car(5, "Toyota", "Camry", "White", 2.4, 28000);
            carShop.Order_Car(5, "Toyota", "Camry", "Black", 2.4, 28000);
            carShop.Order_Car(5, "Toyota", "Prado", "White", 4.4, 48000);
            carShop.Order_Car(5, "Lexus", "Lx570", "White", 4.0, 68000);

            carShop.Order_Car(5, "Lexus", "Gx460", "Black", 4.4, 42000);
            carShop.Order_Car(5, "Lexus", "Gx460", "Blue", 4.4, 42000);

            return carShop;
        }
    }
}
