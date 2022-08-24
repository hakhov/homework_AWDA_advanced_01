using Access_modifiers;
using Library;

Human human = new Human("Bob", 45, 23154);
human.GetInfo();


Employee employee = new Employee("John", 32, 456678, 4500, "Teacher");
employee.GetInfo();


Human human1 = new CreateHuman().CreatingHuman();
human1.GetInfo();