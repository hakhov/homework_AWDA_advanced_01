
    partial class Program
    {
   // [ThreadStatic]
    //static int counter = 0;
    static void MyMethod(object count)
    {
        int x = (int)count;
        Console.WriteLine($"Counter from Thread ={++x}");
    }
    }

