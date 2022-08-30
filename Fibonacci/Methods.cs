
   public partial class Program
   {
    
      static int Fibonacci(int i)
    {
        if (i <= 1)
        {
            return i;
        }
        else
        {
            return Fibonacci(i - 2) + Fibonacci(i - 1);
        }
    }
}


