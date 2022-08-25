Console.WriteLine("Please input text");
string s = Console.ReadLine();
char[] arr = s.ToCharArray();
string s1 = "";
string s2 = "";
for (int i = s.Length - 1; i > 0; i--)
{
    int count = 0;
    
    for (int j= i-1; j>=0; j--)
    {
        if (arr[i]!=arr[j] && Array.LastIndexOf(arr,arr[i])==i)
        {
            ++count;
        }
    }
    if (count == i || (i==0 && Array.LastIndexOf(arr,arr[0])==0))
        s1 += s[i];

    if (count != i && Array.LastIndexOf(arr, arr[i]) == i)
        s2 += s[i];
}
Console.WriteLine();
Console.WriteLine("Problem 1");
for (int k = 0; k < s1.Length; k++)
{
    Console.Write($"{s1[k]}, ");
}
Console.WriteLine();
Console.WriteLine("Problem 2");
for (int k = 0; k < s2.Length; k++)
{
    Console.Write($"{s2[k]}, ");
}
