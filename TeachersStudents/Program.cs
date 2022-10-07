using System;

namespace TeachersStudents
{
    class Program
    {
        static void Main(string[] args)
        {

            Generator obj = new Generator();
            var students = obj.CreateStudnetsGroup(36);
            var teachers = obj.CreateTeachersGroup(6);
            Console.WriteLine("/////////");
            var classRooms = obj.ClassRoomGenerator(teachers, students);
            obj.GetInfoClassroom(classRooms);

        }
    }
}
