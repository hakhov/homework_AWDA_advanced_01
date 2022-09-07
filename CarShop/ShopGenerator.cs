namespace CarShop
{
    internal class ShopGenerator
    {
        public static Car_Shop Generate_EuroCars()
        {
            Car_Shop carShop = new Car_Shop("EuroCars");
            carShop.Order_Car(5, "Mercedes-Benz", "Cls", Color.White, 5.5, 38000);
            carShop.Order_Car(5, "Mercedes-Benz", "Cls", Color.Black, 6.3, 44000);
            carShop.Order_Car(3, "Mercedes-Benz", "Gle", Color.Black, 4.0, 48000);
            carShop.Order_Car(5, "Mercedes-Benz", "S", Color.White, 5.0, 52000);
            carShop.Order_Car(4, "BMW", "X6", Color.Blue, 6.0, 64000);
            carShop.Order_Car(4, "BMW", "F30", Color.White, 3.5, 31000);
            carShop.Order_Car(5, "BMW", "E60", Color.Gray, 3.0, 24000);
            carShop.Order_Car(5, "BMW", "E60", Color.White, 3.0, 24000);
            carShop.Order_Car(3, "Audi", "A6", Color.White, 3.5, 25000);
            carShop.Order_Car(3, "Audi", "A4", Color.Red, 3.0, 27000);
            carShop.Order_Car(3, "Audi", "R8", Color.White, 4.0, 55000);


            return carShop;
        }

        public static Car_Shop Generate_JapanCars()
        {
            Car_Shop carShop = new Car_Shop("JapanCars");
            carShop.Order_Car(5, "Toyota", "Camry", Color.White, 2.4, 28000);
            carShop.Order_Car(5, "Toyota", "Camry", Color.Black, 2.4, 28000);
            carShop.Order_Car(5, "Toyota", "Prado", Color.White, 4.4, 48000);
            carShop.Order_Car(5, "Lexus", "Lx570", Color.White, 4.0, 68000);
            carShop.Order_Car(5, "Lexus", "Gx460", Color.Black, 4.4, 42000);
            carShop.Order_Car(5, "Lexus", "Gx460", Color.Blue, 4.4, 42000);
            carShop.Order_Car(3, "Nissan", "Gtr", Color.Green, 3.0, 22000);
            carShop.Order_Car(3, "Nissan", "Gtr", Color.White, 3.0, 22000);


            return carShop;
        }
    }
}
