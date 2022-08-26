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

            int[,] array = TwoDimensionalArray(2,4);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The max value in array is " + GetMax(array));
            Console.WriteLine("The min value in array is " + GetMin(array));
            Console.WriteLine("Enter the count of Fibonacci members you want to see!");
            Console.WriteLine(FiboSequence(Convert.ToInt32(Console.ReadLine())));
        }
        /// <summary>
        /// Returnes member in Fibonacci sequence 
        /// </summary>
        /// <param name="n" is the integer number of the member which you want></param>
        /// <returns> returnes integer number and -1 if n is not valid</returns>
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
        /// <summary>
        /// Returnes String value - the sequense of Fibonacci numbers by the count is entered!
        /// </summary>
        /// <param name="n" is the count of sequence which will be printed></param>
        /// <returns>String value</returns>
        public static string FiboSequence(int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result+=Fibo(i)+" ";
            }
            return result;
        }

        /// <summary>
        /// Prints Two dimensional array with random numbers from 10 to 100
        /// with the count of rows and coloumns which you enter
        /// </summary>
        /// <param name="row" is integer number - the count of rows></param>
        /// <param name="coloumn" is integer number - the count of coloumns></param>
        public static int[,] TwoDimensionalArray(int row, int coloumn)
        {
            int[,] myArray = new int[row,coloumn];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    myArray[i, j] = (rnd.Next(10, 100));
                }
                Console.WriteLine();
            }
            return myArray;
        }

        /// <summary>
        /// Returnes integer number - the max number in array
        /// </summary>
        /// <param name="array" is a given array></param>
        /// <returns>Integer number</returns>
        public int GetMax(int[] array)
        {
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (result < array[i])
                    result = array[i];
            }
            return result;
        }

        /// <summary>
        /// Returnes integer number - max number from Two Dimensional array
        /// </summary>
        /// <param name="twoDimensionalarray" is the given two dimensional array></param>
        /// <returns>Returnes integer number</returns>
        public static int GetMax(int[,] twoDimensionalarray)
        {
            int result = twoDimensionalarray[0,0];
            for (int i = 1; i < twoDimensionalarray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalarray.GetLength(1); j++)
                {
                    if (result < twoDimensionalarray[i,j])
                        result = twoDimensionalarray[i,j];
                }
                
            }
            return result;
        }

        /// <summary>
        /// Returnes integer number - the min number in array
        /// </summary>
        /// <param name="array" is a given array></param>
        /// <returns>Integer number</returns>
        public int GetMin(int[] array)
        {
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (result > array[i])
                    result = array[i];
            }
            return result;
        }

        /// <summary>
        /// Returnes integer number- min number from Two Dimensional array
        /// </summary>
        /// <param name="twoDimensionalarray" is the given two dimensional array></param>
        /// <returns>Returnes integer number</returns>
        public static int GetMin(int[,] twoDimensionalarray)
        {
            int result = twoDimensionalarray[0, 0];
            for (int i = 1; i < twoDimensionalarray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalarray.GetLength(1); j++)
                {
                    if (result > twoDimensionalarray[i, j])
                        result = twoDimensionalarray[i, j];
                }

            }
            return result;
        }
        /// <summary>
        /// Returnes true if number is prime and false in t he opposite
        /// </summary>
        /// <param name="number" is integer number for checking></param>
        /// <returns>Integer number</returns>
        public bool isPrime(int number)
        {
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
