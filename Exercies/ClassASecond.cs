using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies
{
    public partial class ClassA
    {
        //The maximum item
       public int Get_Max(int[,] arr,int n,int m)
        {
            int max = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if(arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            return max;
        }

        //The minimum item
        public int Get_Min(int[,] arr, int n, int m)
        {
            int min = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }

            return min;
        }


        //Sum of all numbers
        public int Get_Sum(int[,] arr, int n, int m)
        {
            int sum = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }


        //Sort rows in array
        public void Sort(int[,] arr, int n, int m)
        {
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {


                        if (arr[k, i] > arr[k, j])
                        {
                            int t = arr[k, i];
                            arr[k, i] = arr[k, j];
                            arr[k, j] = t;
                        }
                    }

                }
            }

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


    }
}
