namespace Exercies
{
    public partial class ClassA
    {
        //Create an array automatically
        public  int[,] Get_Arr_Auto(int n,int m)
        {
            Random r = new Random();
            int[,] arr = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next(0, 10);
                }
            }
            return arr;
        }

        //Create an array manual
        public int[,] Get_Arr_Manual(int n,int m)
        {
            int[,] arr = new int[n, m];

            Console.WriteLine("Insert the Values");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return arr;
        }


        //Write array 
        public void Write_Arr(int[,] arr,int n,int m)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }

    }
}