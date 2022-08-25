using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class StudentClass : Student
    {
        public void GetInfoChild()
        {
            //protected - hasaneli  zharang classum  nuyn assemblyum
            //internal -hasanel zharang classum  nuyn assemblyum
            //protected internal -hasaneli zharang classum  nuyn assemblyum
            //private protected -hasaneli zharang classum  nuyn assemblyum
            Console.WriteLine($"Age: {age } ,Birth: {birthYear} , LName: {lName}, {name}");
        }
    }
    
}
