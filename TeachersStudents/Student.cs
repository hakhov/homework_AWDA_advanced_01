
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersStudents
{
    public class Student : IBase
    {

        public string name { get; set; }
        public int id { get; set; }
        public string lastName { get; set; }
        public string ocupation { get; set; }

        public  void GetInfo()
        {
            Console.WriteLine($"{this.name}, {this.lastName}, {this.id}, {this.ocupation}");
            
        }


    }
}
