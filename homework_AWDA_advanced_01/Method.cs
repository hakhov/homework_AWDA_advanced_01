
public partial class Program
{
    static string Fibonacci(int qanak, int i = 1, long a = 0, long b = 1)
    {
        if (qanak <= 1)
            return "nermucvac tivy sxal e";

        if (i == 1)
            return $"1{Fibonacci(qanak, i + 1)}";

        if (i > qanak)
            return "";

        long tiv1 = a;
        long tiv2 = b;
        long tiv3 = tiv1 + tiv2;
        tiv1 = tiv2;
        tiv2 = tiv3;
        return $", {tiv3}{Fibonacci(qanak, i + 1, tiv1, tiv2)}";

    }
}

