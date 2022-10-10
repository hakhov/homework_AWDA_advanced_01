using String_Compare;

StringCompare ob = new StringCompare();

Console.Write("Insert first string : ");
string first = Console.ReadLine();
Console.WriteLine();
Console.Write("Insert second string : ");
string second = Console.ReadLine();

ob.CompareString(first, second);