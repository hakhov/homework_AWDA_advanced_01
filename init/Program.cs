using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass() { Age = 20};
            //myClass.Age = 20;
            Console.WriteLine(myClass.Age);
        }
    }

    class MyClass
    {
        //private int age;
        //public MyClass(int a)
        //{
        //    age = a;
        //}
        public int Age { get; init; }
    }
}
