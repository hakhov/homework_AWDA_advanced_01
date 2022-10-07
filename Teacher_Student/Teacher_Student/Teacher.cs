
internal class Teacher : Human, IInformation
{
    public List<Student> Students { get; set; }
    public Teacher(string firstName, string lastName) : base(firstName, lastName)
    {
        Students = new List<Student>();
    }

    public void GetInfo()
    {
        Console.WriteLine("\nTeacher");
        Console.WriteLine($"FirstName:{FirstName}\tLastName:{LastName}");
        Console.WriteLine("________________________________________________");
        Console.WriteLine("Students");
        foreach (var item in Students)
        {
            item.GetInfo();
        }

    }
}



