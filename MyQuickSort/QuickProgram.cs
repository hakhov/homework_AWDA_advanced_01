
public partial class Program
    {
    public static int count = 0;
    public static int[] QuickSort(int[] arr,int firstIndex,int lastIndex)
    {

        if(firstIndex >=lastIndex)
        return arr;

        int pivot = GetPivot(arr,  firstIndex, lastIndex);
        GetPivot(arr, firstIndex, pivot);
        GetPivot(arr,pivot+1,lastIndex);

        return arr;
    }
    private static int GetPivot(int[] arr, int firstIndex, int lastIndex)
    {
        int pivot = firstIndex - 1;
        
        for(int i = firstIndex; i <= lastIndex;i++)
        {
            ++count;
            if(arr[i]<arr[lastIndex])
            {
                pivot++;
                Swap(ref arr[pivot], ref arr[i]);
            }
        }
        pivot++;
        Swap(ref arr[pivot],ref arr[lastIndex]);
        return pivot;   
    }

    private static void Swap(ref int first, ref int last)
    {
        int temp = first;
        first = last;
        last= temp;
    }
}

