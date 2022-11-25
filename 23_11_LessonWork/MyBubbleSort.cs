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
            int temp ;
            int count = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = 1; j < arr.Length - 1; j++)
                {
                    ++count;
                    if (arr[j] >= arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            Console.WriteLine(count);
        }
        public static void Print(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{string.Join(',' , item)}");
            }
        }
    }
}
