using System;

namespace Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for manual version");
            Console.WriteLine("Press 2 for automatic version");
            int a = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[2, 3];
            if (a == 1)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.WriteLine("input {0} number of {1} line", j + 1, i + 1);
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("The Max Value is " + Max(array));
                Console.WriteLine("The Min Value is " + Min(array));
                Console.WriteLine("The Sum of the numbers is " + Sum(array));
                Homework_2.Program.Prime(array);
            }
            else if (a == 2)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Random rnd = new Random();
                        array[i, j] = rnd.Next(1, 100);
                        Console.WriteLine(array[i, j]);
                    }
                }
                Console.WriteLine("The Max Value is " + Max(array));
                Console.WriteLine("The Min Value is " + Min(array));
                Console.WriteLine("The Sum of the numbers is " + Sum(array));
                Homework_2.Program.Prime(array);
            }
            Console.ReadLine();
        }
        static int Max(int[,] array1)
        {
            int max = array1[0, 0];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    if (max < array1[i, j])
                    {
                        max = array1[i, j];
                    }
                }

            }
            return max;

        }

        static int Min(int[,] array2)
        {
            int min = array2[0, 0];
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    if (min > array2[i, j])
                    {
                        min = array2[i, j];
                    }
                }
            }
            return min;
        }

        static int Sum(int[,] array3)
        {
            int sum = 0;
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    sum += array3[i, j];
                }
            }
            return sum;
        }
        static void Prime(int[,] array4)
        {
            string prime = "";
            for (int i = 0; i < array4.GetLength(0); i++)
            {
                for (int j = 0; j < array4.GetLength(1); j++)
                {
                    for (int k = 2; k < array4[i, j]; k++)
                    {
                        if (array4[i, j] % k == 0)
                        {
                            prime = "composite";
                            break;
                        }
                        else
                        {
                            prime = "prime";
                        }
                    }
                    Console.WriteLine(array4[i, j] + " is " + prime);
                }
            }
        }
    }
}
