using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Fibo(number));

            TwoDimensionalArray(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
        }
        /// <summary>
        /// Returnes member in Fibonacci sequence 
        /// </summary>
        /// <param name="n" is the integer number of the member which you want></param>
        /// <returns> integer number and -1 if n is not valid</returns>
        public static int Fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n > 0)
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
            else
            {
                return -1;
            }
        }

        public static void TwoDimensionalArray(int row, int coloumn)
        {
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    Console.Write(rnd.Next(10, 100) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void TwoDimensionalArray()
        {

        }


    }
}
