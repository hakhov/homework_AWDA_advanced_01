using System;

namespace _01_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            MyClass.Age = 50;
            ob.ID = 520;
            Console.WriteLine(ob.ID);
        }
    }

    class MyClass
    {
        public static int Age;
        public int ID;


        public void Display()
        {
            Age++;
            ID++;
        }

        public static void Info()
        {
            int x = 50;
            //ID = 20;
        }
    }
}
