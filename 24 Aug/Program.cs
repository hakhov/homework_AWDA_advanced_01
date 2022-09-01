//Fibonacci

Console.WriteLine(Fibonacci(3));

static int Fibonacci(int fib)
{
    if (fib <= 1)
        return fib;
    return Fibonacci(fib - 1) + Fibonacci(fib - 2);

}

//Array

Random rnd = new();
int row = rnd.Next(1,20);
int col = rnd.Next(1,20);
Console.WriteLine(Array(col, row, col , row));

static int Array(int n, int m, int i, int j)
{
    int[,] matrix = new int[n, m];
    for (i =0; i <= n; i++)
    {
        for (j = 0; j <= m; j++)
        {
            Console.WriteLine(matrix[i,j]);
        }
    }
    return matrix[i,j];

}