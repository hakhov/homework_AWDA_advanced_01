using System;

namespace DrawingOfPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People ();
            People people1 = new People(5, 6, "techer" );
            people.Combination();
            people1.DisplayQuantity();
        }
    }
}
