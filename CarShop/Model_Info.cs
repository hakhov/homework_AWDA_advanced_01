namespace CarShop
{
    internal class Model_Info
    {
        public int Count { get; set; }
        public Car _Car { get; private set; }

        public Model_Info(int count, Car car)
        {
            Count = count;
            _Car = car;
        }


    }
}
