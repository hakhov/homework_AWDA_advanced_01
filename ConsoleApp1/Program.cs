//Ռեկուրսիայի կիրառմամբ ստանալ Ֆիբոնաչիի շարքի անդամները

Console.Write("n=");
int n = int.Parse(Console.ReadLine());
static int Fibonacci(int n)
{
    if (n <= 1)
        return n;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for(int i=0;i<n;i++)
{
    Console.Write("{0}  ", Fibonacci(i));
}

