using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Teacher : Employee, IEmployeeProvider
    {
        public string School { get; set; }
        public Teacher(string name, string gender, int age, decimal salary, string school) : base(name, gender, age, salary)
        {
            School = school;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{FullName}\tGender:{Gender}\tAge:{Age}\tSalary:{Salary}\tSchool:{School}");
        }

        public void ChangeSalary()
        {
            Console.WriteLine($"{FullName}`s sallary is:{Salary}");
            Console.Write("Enter new salary:");
            decimal salary = decimal.Parse(Console.ReadLine());
            Salary = salary;
        }
    }
}
