int[] arr = { -1, 2, 5, 7, 4, 85, 77, 2, 3,54 };
int firstIndex = 0;
int lastIndex=arr.Length - 1;
int[] arrSorted=QuickSort(arr, firstIndex, lastIndex);
Console.WriteLine($"Sorted Array : {string.Join(" , ",arrSorted)}");
Console.WriteLine($"Count : {count} => Big O(2n)");
