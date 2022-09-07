//Operotor_Overloads

using Operator_Overloads;

Point2D point1 = new(0, 20);
point1.ShowInfo();

Point2D point2 = new(10, 15);
point2.ShowInfo();
Console.WriteLine();

Console.WriteLine("Sum");
Point2D sum = point1 + point2;
sum.ShowInfo();

Point2D sum1 = 7 + point2;
sum1.ShowInfo();

Point2D sum2 = point1 + 8;
sum2.ShowInfo();
Console.WriteLine();

Console.WriteLine("Sub");
Point2D sub = point1 - point2;
sub.ShowInfo();

Point2D sub1 = 7 - point2;
sub1.ShowInfo();

Point2D sub2 = point1 - 8;
sub2.ShowInfo();
Console.WriteLine();

Console.WriteLine("Mul");
Point2D mul = point1 * point2;
mul.ShowInfo();

Point2D mul1 = 7 * point2;
mul1.ShowInfo();

Point2D mul2 = point1 * 8;
mul2.ShowInfo();
Console.WriteLine();

Console.WriteLine("Div");
Point2D div = point1 / point2;
div.ShowInfo();

Point2D div1 = 7 / point2;
div1.ShowInfo();

Point2D div2 = point1 / 8;
div2.ShowInfo();