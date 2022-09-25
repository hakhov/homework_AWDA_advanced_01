using EqualsRefEqualsInstance;

Deference ob1 = new Deference();
Deference ob2 = new Deference();

ob1= ob2;


Console.WriteLine($"Object 1 is equals Object 2 {ob1.Equals(ob2)}");
Console.WriteLine($"Object 1 reference is equals to Object 2 reference {ReferenceEquals(ob1,ob2)}");
Console.WriteLine($"Object 1 is equals(with static method) Object 2 {Equals(ob1,ob2)}");
