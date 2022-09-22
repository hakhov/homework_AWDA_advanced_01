using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Doctor : Employee, IEmployeeProvider
    {
        public string Hospital { get; set; }

        public Doctor(string name, string gender, int age, decimal salary, string hospital) : base(name, gender, age, salary)
        {
            Hospital = hospital;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{FullName}\tGender:{Gender}\tAge:{Age}\tSalary:{Salary}\tHospital:{Hospital}");
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
