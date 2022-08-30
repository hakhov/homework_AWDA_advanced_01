Console.WriteLine("If you want the matrix to be generated automatically press 0 otherwise 1");
int a = int.Parse(Console.ReadLine());
Console.Write("Rows = ");
int x = int.Parse(Console.ReadLine());
Console.Write("Column = ");
int y = int.Parse(Console.ReadLine());
int[,] matrix = Matrix(a, x, y);
Print(matrix);
Console.WriteLine($"Max = {GetMax(matrix)}:");
Console.WriteLine();
Console.WriteLine($"Min = {GetMin(matrix)}:");
Console.WriteLine();
Console.WriteLine($"Sum = Max + Min = {GetSum(GetMax(matrix), GetMin(matrix))}:");
Console.WriteLine();
int count = 0;
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (Prime(matrix[i, j]))
        {
            count++;
        }
    }
}
int[] arr4 = new int[count];
int k = 0;
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        if (Prime(matrix[i, j]))
        {
            arr4[k] = matrix[i, j];
            k++;
        }
    }
}


if (count == 0)
{
    Console.WriteLine("Don`t exist");
}
else
{
    Console.Write("Primes are` ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr4[i]}\t");
    }
}
Console.WriteLine();
SortofMatrix(matrix);
