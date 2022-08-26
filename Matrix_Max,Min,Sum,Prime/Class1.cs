public partial class Program
{
    static int sum(int[,] arr)
    {
        int s = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                s += arr[i, j];
        return s;
    }
    static int automatic(int size)
    {
        int[,] arr = new int[size, size];
        Random random = new Random();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = random.Next(-30, 30);
                return arr[i, j];
            }
        }
        return 0;
    }

    static int manual(int size)
    {
        int[,] arr = new int[size, size];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = int.Parse(Console.ReadLine());
                return arr[i, j];
            }
        }
        return 0;
    }
    static int Maximum(int[,] arr)
    {
        int max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (arr[i, j] > max)
                    max = arr[i, j];
        return max;
    }

    static int Minimum(int[,] arr)
    {
        int min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                if (arr[i, j] < min)
                    min = arr[i, j];
        return min;
    }

    static void Sort(int[,] arr, int size)
    {
        int[] arr1 = new int[size * size];
        int k = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
                arr1[k++] = arr[i, j];
        Array.Sort(arr1);
        for (int i = 0; i < k; i++)
            Console.Write($"{arr1[i]},\t");
    }
    static int Prime(int z)
    {
        int t = 0;
        if (z == 1 || z == 0 || z <= 0)
            t = 1;
        for (int k = 2; k < z / 2; k++)
        {
            if (z % k == 0)
            {
                t = 1;
                break;
            }
        }
        return t;
    }
}

