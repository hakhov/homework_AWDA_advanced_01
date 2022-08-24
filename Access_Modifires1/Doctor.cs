using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifires1
{
    internal class Doctor:Employee
    {
        public string Hospital { get; set; }
        public   Doctor(string name, int age, int id, decimal salary, string prof,string hospital):
            base(name,age,id,salary,prof)
        {
            Hospital = hospital;
        }

        public void Getinfo()
        {
            base.GetInfo();
            Console.WriteLine($"Hospital: {Hospital}");
        }
    }
}
