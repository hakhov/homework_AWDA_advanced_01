
ERROR1: Console.Write("Enter teachers count(1-5): ");
int countTeacher = int.Parse(Console.ReadLine());

if (countTeacher < 1 || countTeacher > 5)
{
    Console.WriteLine("Wrong command");
    goto ERROR1;
}

ERROR2: Console.Write("Enter students count(10-50): ");
int countStudent = int.Parse(Console.ReadLine());

if (countStudent < 10 || countStudent > 50)
{
    Console.WriteLine("Wrong command");
    goto ERROR2;
}

List<Teacher> teachers = Manager.ManagerMethod(countTeacher, countStudent);

foreach (var item in teachers)
{
    item.GetInfo();
}