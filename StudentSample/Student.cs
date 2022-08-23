using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_AWDA_advanced_01
{
    class Student
    {
        string name;
        int age;

        public void setInfo(int a, string n)
        {
            name = n;
            age = a;
        }
        public void ShowInfo()
        {
            global::System.Console.WriteLine($"name {name}, age {age}");
        }
    }
}
