static int Fibonacci(int a)
{
    if (a == 1 || a == 2)
    {
        return 1;
    }

    return Fibonacci(a - 1) + Fibonacci(a - 2);
}
Console.WriteLine(Fibonacci(6));
