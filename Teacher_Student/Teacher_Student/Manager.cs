
internal class Manager
{
    public static List<Teacher> ManagerMethod(int countTeacher, int countStudent)
    {
        List<Teacher> teachers = Initializer.InitializeTeachers(countTeacher);
        List<Student> students = Initializer.InitializeStudents(countStudent);
        Random rand = new Random();
        int number;

        int eachTeacher = (countStudent / countTeacher);
        int magelo = countStudent % countTeacher;

        for (int i = 0; i < teachers.Count; i++)
        {
            for (int j = 0; j < eachTeacher; j++)
            {
                number = rand.Next(0, students.Count);
                teachers[i].Students.Add(students[number]);
                students.Remove(students[number]);
            }
        }
        for (int i = 0; i < magelo; i++)
        {
            teachers[i].Students.Add(students[i]);
        }
        return teachers;

    }


}