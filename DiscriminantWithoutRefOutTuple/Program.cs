using DiscriminantWithoutRefOutTuple;

DC obj = new DC();
obj.answer = "Answer\nHas no root";
Console.Write("Formula ( a*x*x+b*x+c = 0 )\nInput value\na = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("c = ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine(obj.MyDiscriminant(a,b,c));