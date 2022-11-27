int[] arr = new int[] { 1, 2, 5, 6, 55, 154, 166, 178, 222, 555 };
int lastIndex=arr.Length-1;
int first = 0;
int target = 15;
bool answer = BinerySearch(arr,target,first,lastIndex);
Console.WriteLine(answer);

bool BinerySearch(int[] arr, int target,int firstIndex,int lastIndex)
{
    int mid=(firstIndex+lastIndex)/2;
    if (firstIndex > lastIndex)
        return false;
    if(arr[mid]==target)
        return true;    
    if(target>arr[mid])
        return BinerySearch(arr, target,mid+1,lastIndex);
    else
        return BinerySearch(arr, target, first, mid-1);
}