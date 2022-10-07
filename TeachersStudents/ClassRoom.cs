using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersStudents
{
    public class ClassRoom
    {
        public Teacher Teacher { get; set; }

        public List<Student> Students { get; set; }

        public ClassRoom(Teacher teacher, List<Student> students)
        {
            this.Teacher = teacher;
            this.Students = students;
        }

        
    }
}
