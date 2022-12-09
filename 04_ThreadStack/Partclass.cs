
    partial class Program
    {
   // [ThreadStatic]
    //static int counter = 0;
    static void MyMethod(object count)
    {
        Console.WriteLine($"Counter from Thread ={++count}");
    }
    }

