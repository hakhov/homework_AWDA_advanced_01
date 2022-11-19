int[] arr = new int[] { 1, 2, 3, 4, 1, 2, 3, 4, 5, 5, 3 };
Array.Sort(arr);
int i = 0;
while (i < arr.Length)
{
    if (Array.IndexOf(arr, arr[i]) < Array.LastIndexOf(arr, arr[i]))
        Console.Write(arr[i] + " , ");

    i = Array.LastIndexOf(arr, arr[i]) + 1;
}

//List<int> list=new List<int>() { 1,2,3,1,5,2,3,9};
//list.Sort();
//int i = 0;
