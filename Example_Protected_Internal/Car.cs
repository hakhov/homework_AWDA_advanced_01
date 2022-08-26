namespace Example_Protected_Internal
{
    public class Car
    {
        public int doors = 4;
        public int wheels = 4;
        protected internal string quality = "Nice";
        protected string apperance = "Adorable";

        public void function()
        {
            Console.WriteLine($"Doors = {doors} Wheels  = {wheels} Quality = {quality} apperance = {apperance}");
        }
    }

    public class Mercedes:Car
    {
        public void Wrtie_fromMercedes()
        {
            Console.WriteLine($"Here I can use quality its: {quality}");
        }
    }

    //to be countinue...
    //-> Fibonacci numbers -> BMW


}