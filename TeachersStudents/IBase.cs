using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersStudents
{
    interface IBase
    {
        string name { get; set; }
        string lastName { get; set; }
        string ocupation { get; set; }
        int id { get; set; }

        void GetInfo();
        
    }
}
