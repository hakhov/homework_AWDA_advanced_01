using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersStudents
{
   public class Generator
    {
        //static  List<Student> StuList = new List<Student>();
      //  static List<Teacher> TeachList = new List<Teacher>();
        public List<Student> CreateStudnetsGroup(int count)
        {
            var StuList = new List<Student>();
            Random random = new Random();
            do
            {
                Student x = new Student();
                x.name = ((Names.Name)random.Next(0, Enum.GetValues(typeof(Names.Name)).Length)).ToString();
                x.lastName = ((Names.SurName)random.Next(0, Enum.GetValues(typeof(Names.SurName)).Length)).ToString();
                x.ocupation = Names.Ocupation.Student.ToString();
                x.id = count;
                count--;
                StuList.Add(x);
               
            } while (count > 0);

            return StuList;
        }
        public void GetInfoStudent(List<Student> students)
        {
            foreach (var student in students)
            {
                student.GetInfo();
            }
        }
        public List<Teacher> CreateTeachersGroup(int count)
        {
            Random random = new Random();
            List<Teacher> TeachList = new List<Teacher>();
            do
            {
                Teacher x1 = new Teacher();
                x1.name = ((Names.Name)random.Next(0, Enum.GetValues(typeof(Names.Name)).Length)).ToString();
                x1.lastName = ((Names.SurName)random.Next(0, Enum.GetValues(typeof(Names.SurName)).Length)).ToString();
                x1.ocupation = Names.Ocupation.Teacher.ToString();
                x1.id = count;
                count--;
                TeachList.Add(x1);
            } while (count > 0);
            return TeachList;
        }
        public void GetInfoTeacher(List<Teacher> teachers)
        {
            foreach (var teacher in teachers)
            {
                teacher.GetInfo();
            }
        }
        public List<ClassRoom> ClassRoomGenerator(List<Teacher> teachers, List<Student> students)
        {
            var result = new List<ClassRoom>();
            int classrooms =students.Count / teachers.Count;
            
            for (int i = 0; i < teachers.Count; i++)
            {
                var x = new List<Student>();
                if (i == (teachers.Count - 1))
                {
                    x = students;
                    ClassRoom classRoom1 = new ClassRoom(teachers[i], x);
                    result.Add(classRoom1);
                    return result;

                }
               
                for (int j = 0; j < classrooms; j++)
                {
                  
                    x.Add(students[j]);
                    students.Remove(students[j]);
                   
                }
                ClassRoom classRoom = new ClassRoom(teachers[i],x);
                
                result.Add(classRoom);
            }
            return result;
        }
        public void GetInfoClassroom(List<ClassRoom> classRooms)
        {
            foreach (var classRoom in classRooms)
            {
                classRoom.Teacher.GetInfo();
                Console.WriteLine();
                foreach (var student in classRoom.Students)
                {
                    student.GetInfo();
                }
                Console.WriteLine("/////////////////////////////////////////////////////////////////////////////////////");
            }
        }
    }
}
