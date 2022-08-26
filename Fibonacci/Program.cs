//Ռեկուրսիայի կիրառմամբ ստանալ Ֆիբոնաչչի շաչքի անդամները։
Console.Write("Please write a quantity of a Fibonacci numbers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
    Console.Write($"{Fibonacci(i)},");
static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
