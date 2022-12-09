Myclass myclass = new();

    



for (int i = 0; i < 3; i++)
{
    new Thread(myclass.MyMethod).Start();
}

class Myclass
{
    object block=new object();
    public void MyMethod()
    {
        //  Monitor.Enter(block);
        lock (block)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Secondary Thread ID = {Thread.CurrentThread.ManagedThreadId}  Itteration = {i}");
                Thread.Sleep(1200);
            }
        }
      //  Monitor.Exit(block);
    }
}