using _07_Tuple_RefOut;

double a = 1;
double b = -3;
double c = 2;

(double, double) result_tuple = ClassMethods.Discriminant_tuple(a, b, c);
Console.WriteLine($"Tuple Solution1: {result_tuple.Item1}\t Solution2: {result_tuple.Item2}");
Console.WriteLine("____________________________________");

double x2 = 0;
double x1 = ClassMethods.Discriminant_Out(a, b, c, out x2);
Console.WriteLine($"Using Out Solution1: {x1}\t Solution2: {x2}");

Console.WriteLine("____________________________________");
Solution solution=ClassMethods.SimpleSolution(a, b, c);
solution.Print();




