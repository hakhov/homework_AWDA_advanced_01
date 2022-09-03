using DiscriminantWithRef;

MyDC obj = new MyDC();
Console.Write("Formula ( a*x*x+b*x+c = 0 )\nInput value\na = ");
double a = double.Parse(Console.ReadLine());
Console.Write("b = ");
double b = double.Parse(Console.ReadLine());
Console.Write("c = ");
double c = double.Parse(Console.ReadLine());
var members=new Tuple<double,double,double>(a,b,c);
Console.Write($"Give different values of x for the experiment :\n x1 = ");
double x1=double.Parse(Console.ReadLine());
Console.Write("x2 = ");
double x2 = double.Parse(Console.ReadLine());
obj.Discriminant(members,ref x1,ref x2);