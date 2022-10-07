
static class Initializer
{
    public static List<Teacher> InitializeTeachers(int count)
    {
        List<Teacher> teachers = new List<Teacher>();
        Random rand = new Random();
        int number;
        for (int i = 0; i < count; i++)
        {
            number = rand.Next(0, Data.Teachers.Count);
            teachers.Add(Data.Teachers[number]);
            Data.Teachers.Remove(Data.Teachers[number]);

        }
        return teachers;
    }

    public static List<Student> InitializeStudents(int count)
    {
        List<Student> students = new List<Student>();
        Random rand = new Random();
        int number;

        for (int i = 0; i < count; i++)
        {
            number = rand.Next(0, Data.Students.Count);
            students.Add(Data.Students[number]);
            Data.Students.Remove(Data.Students[number]);
        }
        return students;
    }
}