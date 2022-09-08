using Get_discriminant_with_ref;

Console.Write("a=");
double a = double.Parse(Console.ReadLine());
Console.Write("b=");
double b = double.Parse(Console.ReadLine());
Console.Write("c=");
double c = double.Parse(Console.ReadLine());

Console.WriteLine(Disc.GetX(ref a, ref b, ref c));
