using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_11_LessonWork
{
    public class MyBubbleSort
    {
        public static void MySort(int[] arr)
        {
            int temp;
            int count = 0;
            bool swapped;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                swapped = false;
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    ++count;
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                    
                }
                if (!swapped)
                {
                    break;
                }
            }
            Console.WriteLine($"Count is {count}");
        }
        public static void Print(int[] array)
        {
            Console.Write($"Sorted array - {string.Join(',', array)}");
            Console.WriteLine();
        }
    }
}
