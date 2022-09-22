using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Employee
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, string gender, int age, decimal salary)
        {
            FullName = name;
            Gender = gender;
            Age = age;
            Salary = salary;
        }

    }
}
