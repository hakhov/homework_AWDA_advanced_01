using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    partial class Program
    {

        static int[] GenarateArrayManual(int qanak)
        {
            int[] arrM = new int[qanak];
            for (int i = 0; i < qanak; i++)
            {
                arrM[i] = int.Parse(Console.ReadLine());
            }
            return arrM;
        }
        static int[,] GenarateMatrixManual(int col, int row)
        {
            int[,] matM = new int[col, row];
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matM[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matM;
        }
        static int[] GenarateArrayAuto(int qanak)
        {
            int[] arrA = new int[qanak];
            Random rnd = new();
            for (int i = 0; i < qanak; i++)
            {
                arrA[i] = rnd.Next(0, 30);
            }
            return arrA;
        }
        static int[,] GenarateMatrixAuto(int col, int row)
        {
            int[,] matA = new int[col, row];
            Random rnd = new();
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matA[i, j] = rnd.Next(0, 30);
                }
            }
            return matA;
        }
        static void ArrayPrint(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void MatrixPrint(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        

        //arrayi hamar
        static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static void GetPrime(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                        break;
                    else
                        Console.Write(arr[i] + " ");
                }

            }
        }
        static void GetSorted(int[] arr)
        {
            Array.Sort(arr);
        }
        //matrixi hamar
    static int GetMaxOfMatrix(int[,] arr)
    {
        int max = arr[0, 0];
        //int maxI = 0, maxJ = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max) { max = arr[i, j]; }// maxI = i; maxJ = j; }
            }
        }
        return max;
    }
    static int GetMinOfMatrix(int[,] arr)
    {
        int min = arr[0, 0];
        //int minI = 0, minJ = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min) { min = arr[i, j]; } //minI = i; minJ = j; }
            }
        }
        return min;
    }
}

