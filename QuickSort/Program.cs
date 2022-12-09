
int[] arr = { 13, 1, 10, 2, 9, 3, 11, 4, 8, 5, 6 };
int firstIndex=0;
int lastIndex=arr.Length-1;
int[] sortedArr= QuickSort(arr,firstIndex, lastIndex);
Console.WriteLine($"Sorted Array : {string.Join(',', sortedArr)}");

