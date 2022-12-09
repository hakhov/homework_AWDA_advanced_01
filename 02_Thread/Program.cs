Thread thread = Thread.CurrentThread;
thread.Name = "Primary";

Console.WriteLine($"{thread.Name}-{thread.ManagedThreadId}");

Thread secondaryThread = new Thread(MyMethod);
secondaryThread.Start();

for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{new string(' ', 10)} -{thread.Name}-{i}");
    Thread.Sleep(1200);
}

static void MyMethod()
{
    Thread thread = Thread.CurrentThread;
    thread.Name = "Secondary";
    for (int i = 0; i < 35; i++)
    {
        Console.WriteLine($"{new string(' ', 20)}-{thread.Name} -{i}-THREAD USING=>{thread.ManagedThreadId}");
        Thread.Sleep(1000);
    }

}