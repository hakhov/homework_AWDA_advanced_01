Console.Write("count=");
int count=int.Parse(Console.ReadLine());
int[] arr=new int[count];
arr[0] = 0;
arr[1] = 1;
Console.Write(arr[0]+"  "+arr[1] +"  ");
int i = 2;
Fibonacci(count);
void Fibonacci(int count)
{
    if (count > 2)
    {
        arr[i] = arr [i - 2] + arr [i - 1];
        Console.Write($"{arr[i]}  ");
        ++i;
        Fibonacci(count - 1);
    }  
}