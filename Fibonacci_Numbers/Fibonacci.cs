namespace Fibonacci_Numbers
{
    public class Fibonacci
    {
        public int Get_Fib_Number(int n)
        {
            if (n <= 2)
                return 1;
            else
                return Get_Fib_Number(n - 1) + Get_Fib_Number(n - 2);
        }
    }

}
