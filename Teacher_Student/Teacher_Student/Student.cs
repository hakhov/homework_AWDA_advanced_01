
internal class Student : Human, IInformation
{

    public Student(string firstName, string lastName) : base(firstName, lastName)
    {

    }

    public void GetInfo()
    {
        Console.WriteLine($"FirstName:{FirstName}\tLastName:{LastName}");
    }
}