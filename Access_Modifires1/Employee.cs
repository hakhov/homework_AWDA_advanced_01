using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifires1
{
    internal class Employee:Human
    {
        public decimal Salary { get; set; }
        private protected string Profession { get; set; }

        public Employee(string name, int age, int id, decimal salary, string prof) : base(name, age, id)
        {
            Salary = salary;
            Profession = prof;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Salary: {Salary} Profession: {Profession}");
        }
    }
}
