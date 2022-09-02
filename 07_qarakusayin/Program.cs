Console.WriteLine("ax^2+bx+c");
Console.Write("type the a of quadratic equation:");
double a= double.Parse(Console.ReadLine());    
Console.Write("type the b of quadratic equation:");
double b = double.Parse(Console.ReadLine());
Console.Write("type the c of quadratic equation:");
double c = double.Parse(Console.ReadLine());

Console.WriteLine(GetRoots(a, b, c));
GetRootsWithRef(ref a, ref b , ref c);