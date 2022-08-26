using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies
{
    public partial class ClassA
    {

        //Check if number is prime or not
        public bool isPrime(int n)
        {
            int count = 0;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count > 0)
                return false;
            return true;
        }

        //Get count of prime numbers for array size
        public  int Prime_Count(int[,]arr, int n, int m)
        {

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(arr[i, j]))
                    {
                        count++;
                    }
                }
            }

            return count; 
        }

        

        //Array with prime numbers
        public int[] Get_Primes(int[,] arr, int n, int m)
        {
            int[] PrimeArr = new int[Prime_Count(arr, n, m)];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (isPrime(arr[i, j]))
                    {
                        PrimeArr[k] = arr[i, j];
                        k++;
                    }
                }
            }

            return PrimeArr;
        }   

        public void Write_Arr(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"\t");
            }
        }

    }
}
