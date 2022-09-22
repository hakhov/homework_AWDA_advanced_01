using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Programmer : Employee, IEmployeeProvider
    {
        public string Language { get; set; }
        public Programmer(string name, string gender, int age, decimal salary, string language) : base(name, gender, age, salary)
        {
            Language = language;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{FullName}\tGender:{Gender}\tAge:{Age}\tSalary:{Salary}\tLanguage:{Language}");
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
