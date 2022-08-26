//Մեթոդների կիրառմամբ ստեղծել զանգվածի ստացման ավտոմատ և մանուալ տարբերակներ։ 
//Գտնել Max, Min, Sum, Prime, Sort գաղափարները։ 
Console.Write("Please enter the size of the matrix: ");
int size = int.Parse(Console.ReadLine());
int[,] arr = new int[size, size];
Console.Write($"Matrix to be printed on the screen automatic or manual?\n");
Console.Write("Write 1 for automatic and 0 for manual: ");
int am = int.Parse(Console.ReadLine());
if (am != 0 && am != 1)
    do
    {
        Console.Write("Please write only 1 or 0: ");
        am = int.Parse(Console.ReadLine());
    }
    while (am != 0 && am != 1);

if (am == 1)
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = automatic(size);
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
else
{
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = manual(size);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}\t");
        Console.WriteLine();
    }
}

Console.WriteLine($"The sum of the matrix numbers: {sum(arr)}");
Console.WriteLine($"The maximum element of the matrix: {Maximum(arr)}");
Console.WriteLine($"The minimum element of the matrix: {Minimum(arr)}");
Console.WriteLine("Matrix elements in ascending order");
Sort(arr, size);
Console.WriteLine();
Console.WriteLine("There are a prime numbers of matrix");
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int t = Prime(arr[i, j]);
        if (t == 0)
            Console.Write($"{arr[i, j]},");
    }

