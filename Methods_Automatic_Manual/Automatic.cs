
public class Automatic
{
    public double max;
    public double min;
    public double sum;
    public double prime;
    public double sort;
    public int i, j;

    static Random r = new Random();

    public int n = r.Next(1, 5);
    public int m = r.Next(1, 5);

    public double[,] arr;
    public Automatic()
    {
        arr = new double[n, m];
        for ( i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = r.Next(10);
     
            }
        }
    }
    public void AutomaticArray()
    {
        Console.WriteLine();
        Console.WriteLine($"n  = {n}");
        Console.WriteLine($"m  =  {m}");
        Console.WriteLine("-------------Array-------------");
        for (i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }

    public double AutomaticMax()
    {
        Console.WriteLine("--------Answer-----------");
        max = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j <arr.GetLength(1);j++)
            {
                if (arr[i, j] > max)
                    max = arr[i, j];
            }
        }
        return max;
    }
    
    public double AutomaticMin()
    {
        min = arr[0, 0];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1);j++)
            {
                 if (arr[i, j] < min)
                min = arr[i, j];
            }
        }
        return min;
    }
    public double AutomaticSum()
    {
        for (int i = 0; i < arr.GetLength(0);i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum+=arr[i, j];
            }
        }
        return sum;
    }

    //public void AutomaticSort()
    //{
    //    Array.Sort(arr);
    //    for (int i = 0; i < arr.GetLength(0); i++)
    //    {
    //        for (int j = 0; j < arr.GetLength(1); j++)
    //        {
    //            Console.Write(arr[i, j] + "\t");
    //        }
    //        Console.WriteLine();
    //    }
    //}
    public int Prime(double n)
    { bool answer2=true;
        for (int i = 2; i <=Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                answer2 = false;
                break;
            }
            else
                answer2 = true; 
        }
        if (answer2 && n!=1 && n!=0)
            return (int)n;
        else
            return (-1);
    }
    public void AutomaticPrime()
    {
        Console.WriteLine();
        Console.WriteLine("Answer Prime\n");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i,j]==Prime(arr[i,j]))
                    Console.Write(arr[i,j]+"\t");
            }
        }
    }
}

