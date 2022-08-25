using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Prime_Sum_Sort_with_methods
{
    internal class Matrix
    {
        public void SetAuto()
        {
            Random r = new();
            int n = r.Next(2, 10);
            int[,] arr = new int[n, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(-20, 30);
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            int max = arr[0, 0];
            int min = arr[0, 0];
            int s = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    s += arr[i, j];
                    if (arr[i, j] > max)
                        max = arr[i, j];
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
            Console.WriteLine($"sum={s}");


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] <= 1)
                        continue;
                    bool t = true;
                    for (int m = 2; m < arr[i, j] / 2; m++)
                    {
                        if (arr[i, j] % m == 0)
                        {
                            t = false;
                            break;
                        }
                    }
                    if (t == true)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1) - 1; j > 0; j--)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            int myTemp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = myTemp;
                        }
                    }

                }
            }

            Console.WriteLine("Sorted matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write($"{arr[i, k]}\t");
                }
                Console.WriteLine();
            }
        }
        public void SetManual()
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"arr[{i},{j}] = ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            int max = arr[0, 0];
            int min = arr[0, 0];
            int s = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    s += arr[i, j];
                    if (arr[i, j] > max)
                        max = arr[i, j];
                    if (arr[i, j] < min)
                        min = arr[i, j];
                }
            }
            Console.WriteLine($"max={max}");
            Console.WriteLine($"min={min}");
            Console.WriteLine($"sum={s}");


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] <= 1)
                        continue;
                    bool t = true;
                    for (int a = 2; a < arr[i, j] / 2; a++)
                    {
                        if (arr[i, j] % m == 0)
                        {
                            t = false;
                            break;
                        }
                    }
                    if (t == true)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = arr.GetLength(1) - 1; j > 0; j--)
                {
                    for (int k = 0; k < j; k++)
                    {
                        if (arr[i, k] > arr[i, k + 1])
                        {
                            int myTemp = arr[i, k];
                            arr[i, k] = arr[i, k + 1];
                            arr[i, k + 1] = myTemp;
                        }
                    }

                }
            }

            Console.WriteLine("Sorted matrix");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    Console.Write($"{arr[i, k]}\t");
                }
                Console.WriteLine();
            }

        }

    }
}