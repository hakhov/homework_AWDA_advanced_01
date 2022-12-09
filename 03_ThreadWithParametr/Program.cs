Thread th = Thread.CurrentThread;
th.Name = "Primary";
Console.WriteLine($"{th.Name}-{th.ManagedThreadId}");
ParameterizedThreadStart parameterized = MyMethod;
Thread thread=new Thread(parameterized);
thread.Start("Hello World");
Thread.Sleep(500);
Console.WriteLine(" Primary end");
static void MyMethod(object? obj )
{
    Thread thread = Thread.CurrentThread;
    thread.Name = "Secondary";
    Console.WriteLine($"{thread.Name}-{thread.ManagedThreadId}");
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{obj}-{thread.Name} -{i}-THREAD USING=>{thread.ManagedThreadId}");
        Thread.Sleep(500);
        
    }
    Console.WriteLine(" Secondary end");
}