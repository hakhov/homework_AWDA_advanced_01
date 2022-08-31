  public class Manual
    {
    public double max;
    public double min;
    public double sum;
    public double prime;
    public double sort;
    public int n, m;
    public double[,] arr2;
    int i, j;
    public Manual(int n,int m)
    {
        this.n = n;
       this.m = m; 
        for ( i = 0; i < n; i++)
        {
            for ( j = 0; j < m; j++)
            {
                Console.Write($"arr[{i},{j}] = ");
                arr2[i, j] = int.Parse(Console.ReadLine());
                //Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }

    public double ManualMax()
    {
        max = arr2[0, 0];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr2[i, j] > max)
                    max = arr2[i, j];
            }
        }
        return max;
    }

    public double ManualMin()
    {
        min = arr2[0, 0];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr2 [i, j] < min)
                    min = arr2[i, j];
            }
        }
        return min;
    }
    public double ManualSum()
    {        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                sum += arr2[i, j];
            }
        }
        return sum;
    }

    public void ManualSort()
    {
        Array.Sort(arr2);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(arr2[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


