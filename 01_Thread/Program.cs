//Thread primaryThread = Thread.CurrentThread;
//Console.WriteLine($"Thread ID = {primaryThread.ManagedThreadId}");
using System.Threading;


//ThreadStart threadStart = new ThreadStart(MyMethod);
//Thread thread=new Thread(threadStart);	
//thread.Start();

//Thread thread = new Thread(MyMethod);
//thread.Start();
Thread thread = new Thread(() =>
{

    while (true)
    {
        Console.WriteLine(new string(' ', 10) + "Secondary Method");
    }
});
thread.Start();
while (true)
{
    Console.WriteLine("Primary");
}
static void MyMethod()
{
    while (true)
    {
        Console.WriteLine(new string(' ', 10) + "Secondary Method");
    }
}
