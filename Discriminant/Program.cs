using CountDiscriminant;



//First Solution

//QuadraticEquation ob = new QuadraticEquation();

//Console.Write("Insert A : ");
//int.TryParse(Console.ReadLine(),out int a);
//Console.WriteLine();
//Console.Write("Insert B : ");
//int.TryParse(Console.ReadLine(), out int b);
//Console.WriteLine();
//Console.Write("Insert C : ");
//int.TryParse(Console.ReadLine(), out int c);
//Console.WriteLine();

//double x = 0;
//double y = 0;

//ob.GetSolution(a,b,c,ref x,ref y);

//Console.WriteLine($"X : {x}  Y : {y}");



//Second Solution


SimpleQuadraticEquation ob1 = new SimpleQuadraticEquation();
Console.Write("Insert A : ");
int.TryParse(Console.ReadLine(), out int a);
Console.WriteLine();
Console.Write("Insert B : ");
int.TryParse(Console.ReadLine(), out int b);
Console.WriteLine();
Console.Write("Insert C : ");
int.TryParse(Console.ReadLine(), out int c);
Console.WriteLine();

FirstClass obb = ob1.GetSolution(a, b, c);

Console.WriteLine($"X : {obb.x}  Y : {obb.y}");







