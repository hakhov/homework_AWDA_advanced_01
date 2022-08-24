using Access_Modifires1;
using Library;


List<Human> humen = new List<Human>();

Human human = new Human("John" ,42,1564654);
humen.Add(human);


Human human1 = new CreateHuman().CreatingHuman();
humen.Add(human1);


Employee employee = new Employee("Emily", 25, 4565454, 4500, "Teacher");
humen.Add(employee);


Doctor doctor = new Doctor("Bob", 42, 56698, 8000, "Heart_Doctor", "Izmirlyan");
humen.Add(doctor);

foreach (var item in humen)
{
    item.GetInfo();
    Console.WriteLine();
}


