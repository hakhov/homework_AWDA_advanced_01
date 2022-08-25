using Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifieryTest
{
    class Teacher:Student
    {
       public void GetTeacherInfo()
        {
            //protected - hasaneli zharang classum angam urish assemblyum
            //internal - voch hasaneli urish assemblium zharangi mot
            //protected internal -hasaneli zharang classum  urish assemblyum
            //private protected -voch hasaneli voch zharang classum  urish assemblyum
            Console.WriteLine($"Studentic zharangac age vory gtnvum er ayl assemblyum {age}, LName{lName} ");
        }
    }
}
