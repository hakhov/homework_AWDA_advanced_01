using System;

namespace Human
{
   public class Student
    {
        protected int age;
        internal int birthYear;
        protected internal string lName;
        private protected string name;

        public void GetInfo()
        {
            Console.WriteLine($"LName: {lName}, Name: {name}, Age: {age}, BirthYear:{birthYear}");
        }
        
    }
}
