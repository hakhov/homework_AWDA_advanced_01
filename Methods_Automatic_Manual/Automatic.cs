
public class Automatic
{
    public double max;
    public double min;
    public double sum;
    public double prime;
    public double sort;
    public int i ,j;
    private Random r = new Random();
    public double[,] arr=new double[5,5]; 
    public Automatic()
    {   
        for ( i = 0; i < arr.GetLength(0); i++)
        {
            for (j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = r.Next(10);
                Console.Write(arr[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
    
    public double AutomaticMax()
    { 
        max = arr[0, 0];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5;j++)
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
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5;j++)
            {
                 if (arr[i, j] < min)
                min = arr[i, j];
            }
        }
        return min;
    }
    public double AutomaticSum()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                sum+=arr[i, j];
            }
        }
        return sum;
    }
    
    public void AutomaticSort()
    {
        Array.Sort(arr);
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(arr[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
}

