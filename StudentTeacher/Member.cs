using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{

    public  class Member
    {
        public Names.Name name { get; set ; }
        public Names.LastName lastName { get; set; }
        public int id { get; set; }
        public string ocupation { get; set; }
        public  string ToString()
        {
            return $"{name}, {lastName}, {id}, {ocupation}";
        }
    }

}
