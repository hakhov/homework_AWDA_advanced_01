using System;

namespace TeachersStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter number of Students->");    
            var x = int.Parse(Console.ReadLine());
            Console.Write("Please enter number of Teachers->");
            var y = int.Parse(Console.ReadLine());
            Generator obj = new Generator();
            var students = obj.CreateStudnetsGroup(x);
            var teachers = obj.CreateTeachersGroup(y);
            Console.WriteLine("/////////");
            var classRooms = obj.ClassRoomGenerator(teachers, students);
            obj.GetInfoClassroom(classRooms);
            
        }
    }
}
