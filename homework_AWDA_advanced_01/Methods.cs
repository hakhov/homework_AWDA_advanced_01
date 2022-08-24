using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_AWDA_advanced_01
{
    internal class Methods
    {
        // Գտնել Max, Min, Sum, Prime, Sort գաղափարները

        public static int Max(int [] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;            
        }

        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int Sum(int [] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
            
        }

        public static List<int> Prime(int[] arr)
        {
            List<int> prime_numbers = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (Prime(arr[i]))
                {
                    prime_numbers.Add(arr[i]);
                }
            }
            return prime_numbers;
        }

        public static bool Prime(int num)
        {
            for (int i = 2; i < num/2; i++)
            {
                if (num%i==0)
                {
                    return false;
                }
            }
            return true;
        }


        public static int[] Sort(int [] arr)
        {
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        public static void Print(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+", ");
            }
        }

    }
}
