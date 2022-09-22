using Interface;
using System.Linq;


List<IEmployeeProvider> employees = new List<IEmployeeProvider>();
employees.Add(new Doctor("Bob Smith", "Male", 42, 4000, "Republic Hospital"));
employees.Add(new Programmer("Kevin Dark", "Male", 25, 4800, "C#"));
employees.Add(new Teacher("Emily Gray", "Female", 27, 3500, "N7"));
employees.Add(new Doctor("Leo Green", "Male", 32, 4300, "Republic Hospital"));
employees.Add(new Programmer("Mia Clark", "Female", 25, 4700, "C#"));
employees.Add(new Teacher("John Lee", "Male", 27, 4500, "N8"));

foreach (var item in employees)
{
    item.GetInfo();
}
Console.WriteLine();

foreach (var item in employees)
{
    Console.WriteLine();
    item.ChangeSalary();
}

Programmer programmer = new Programmer("Jame Hardy", "Male", 30, 4200, "C++");
employees.Add(programmer);

Console.WriteLine();
foreach (var item in employees)
{
    item.GetInfo();
}


