using OperatorOverloads;

Point2D point_1 = new(10, -4);
Point2D point_2 = new(0, 5);
Console.Write("point_1 \t");
point_1.ShowInfo();
Console.Write("point_2 \t");
point_2.ShowInfo();

Console.WriteLine("");

Point2D point_3 = new();
point_3 = point_1 + point_2;
Console.Write("point_1 + point_2 \t");
point_3.ShowInfo();

Console.WriteLine("");

Point2D point_9 = new();
point_9 = point_1++;
Console.Write("point_1++ \t");
point_9.ShowInfo();

Console.WriteLine("");
//Console.Write((point_1++).ShowInfo());


Console.WriteLine("");

Point2D point_10 = new();
point_10 = ++point_2;
Console.Write("++point_2 \t");
point_10.ShowInfo();

Console.WriteLine("");
//Console.Write(++point_2);


Console.WriteLine("");

Point2D point_4 = new();
point_4 = point_1 - point_2;
Console.Write("point_1 - point_2 \t");
point_4.ShowInfo();

Console.WriteLine("");

Point2D point_5 = new();
point_5 = point_1 / point_2;
Console.Write("point_1 / point_2 \t");
point_5.ShowInfo();

Console.WriteLine("");

Point2D point_6 = new();
point_6 = point_1 * point_2;
Console.Write("point_1 * point_2 \t");
point_6.ShowInfo();

Console.WriteLine("");

Point2D point_7 = new();
point_7 = point_1 + 8;
Console.Write("point_1 + 8 \t");
point_7.ShowInfo();

Console.WriteLine("");

Point2D point_8 = new();
point_8 = point_1 * 3;
Console.Write("point_1 * 3 \t");
point_8.ShowInfo();



int z = 8;
z++;
Console.WriteLine(z);
int k = 8;
++k;
Console.WriteLine(k);

