
using System.Collections;

internal class Teacher : Human, IInformation, IEnumerable
{
    public List<Student> Students { get; set; }
    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    {
        Students = new List<Student>();
    }

    public void GetInfo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nTeacher");
        Console.WriteLine($"FirstName:{FirstName}\tLastName:{LastName}");
        Console.WriteLine("________________________________________________");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Students");
        foreach (var item in Students)
        {
            item.GetInfo();
        }

    }

    public IEnumerator GetEnumerator()
    {
        return Students.GetEnumerator();
    }
}



