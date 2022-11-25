using System;

namespace _23_11_LessonWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -95, 256, -1, 0, 8, 215, -65, 1, 2, 2, 2 };
            MyBubbleSort.MySort(array);
            MyBubbleSort.Print(array);
        }
    }
}
