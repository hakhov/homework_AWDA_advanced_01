
public partial class Program
{
    static int[,] Matrix(int a, int x, int y)
    {
        int[,] matrix1 = new int[x, y];
        if (a == 0)
        {
            Random rnd1 = new Random();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix1[i, j] = rnd1.Next(-50, 50);
                }
            }
        }
        else
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"matrix[{i},{j}]= ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        return matrix1;
    }


    static int GetMax(int[,] matrix1)
    {
        int max = matrix1[0, 0];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                if (matrix1[i, j] > max)
                {
                    max = matrix1[i, j];
                }
            }
        }
        return max;
    }
    static int GetMin(int[,] matrix1)
    {
        int min = matrix1[0, 0];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                if (matrix1[i, j] < min)
                {
                    min = matrix1[i, j];
                }
            }
        }
        return min;
    }
    static int GetSum(int GetMax, int GetMin)
    {
        return GetMax + GetMin;
    }
    static int[,] Print(int[,] matrix1)
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write($"{matrix1[i, j]}\t");
            }
            Console.WriteLine();
        }
        return matrix1;

    }

    static bool Prime(int x)
    {
        if (x <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(x); i++)
        {

            if (x % i == 0)
            {
                return false;
            }
        }
        return true;


    }

    static int[,] SortofMatrix(int[,] matrix1)
    {
        int temp = 0;
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 1; j < matrix1.GetLength(1); j++)
            {
                if (matrix1[i, j - 1] > matrix1[i, j])
                {
                    temp = matrix1[i, j-1];
                    matrix1[i, j-1] = matrix1[i, j];
                    matrix1[i, j] = temp;
                }
            }

        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write($"{matrix1[i, j]}\t");
            }
            Console.WriteLine();
        }
                return matrix1;

    }
}
