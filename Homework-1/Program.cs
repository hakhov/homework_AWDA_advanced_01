using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ռեկուրսիայի կիրառմամբ ստանալ Ֆիբոնաչիի շարքի թվերը։
            Console.WriteLine(Fibonacci(9));
            Console.ReadLine();
        }
        static int Fibonacci(int number)
        {
            if (number == 1)
            {
                return 0;
            }
            else if (number == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }
    }
}
