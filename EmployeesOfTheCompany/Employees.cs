public class Employees
{
    private string _name;
    private string _type;
    private int _age;
    private int _id;
    public void OneDeveloper(IEmployeesData obj)
    {
        _name = obj.employeesName();
        _type = obj.employeesType();
        _age = obj.employeeAge();
        _id = obj.employeeId();
        Console.Write($"Employees > ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(_type);
        Console.ResetColor();
        Console.Write("Name > ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(_name);
        Console.ResetColor();
        Console.Write("Age > ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(_age);
        Console.ResetColor();
        Console.Write("ID > ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(_id);
        Console.ResetColor();
    }
}