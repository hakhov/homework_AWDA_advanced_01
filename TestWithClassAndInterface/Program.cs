using System;

namespace TestWithClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.EatingProcess();
            IEat eat = new Human();
            eat.EatingProcess();
            MyEatingMethod myEatingMethod = new Human();
            myEatingMethod.EatingProcess();

        }
    }
}
