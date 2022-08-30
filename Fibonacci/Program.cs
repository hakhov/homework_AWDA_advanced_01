Console.Write("Enter number ");
int x = int.Parse(Console.ReadLine());
int[] arr = new int[x];
for (int i = 0; i < x; i++)
{
    arr[i] = Fibonacci(i);
}
for (int i = 0; i < x; i++)
{
    Console.Write($"{arr[i]}\t");
}
