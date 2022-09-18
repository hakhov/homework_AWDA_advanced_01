using OperationsOverloading;
Point2D point1=new Point2D();
point1.x = 20;
point1.y = 10;

Point2D point2 = new Point2D(24,16);

Point2D point = point1 + point2;
Console.WriteLine($"x={point.x},y={point.y}");//44,26

point = point1 - point2;
Console.WriteLine($"x={point.x},y={point.y}");//-4,-6

point = point1 * point2;
Console.WriteLine($"x={point.x},y={point.y}");//480,160

point = point1 / point2;
Console.WriteLine($"x={point.x},y={point.y}");//0.83,0.625



point1++;
point2--;



