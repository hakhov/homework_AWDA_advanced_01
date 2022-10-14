using System.Runtime.CompilerServices;
using System.Text;

string a = "abcdefgasd";
string b = "11111";
Console.WriteLine(a.MyInsert(3, b));

Console.WriteLine(b.Replace('1', '2'));

char t = '0';
if (t.Equals('0'))
{
    Console.WriteLine("hello");
}
if (t.Equals(48))
{
    Console.WriteLine("world");
}
if (t == 48)
{
    Console.WriteLine("iiiiiiiii");
}
Console.WriteLine(t.CompareTo('0'));



static class Extension
{
    public static string MyReplace(this string str, char a, char b)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == a)
            {
                result.Append(b);
            }
            else
            {
                result.Append(str[i]);
            }
        }
        return result.ToString();
    }


    public static string MyInsert(this string str, int startindex, string txt)
    {
        StringBuilder result = new StringBuilder();
        result.Append(str.Substring(0, startindex));
        result.Append(txt);
        result.Append(str.Substring(startindex));
        return result.ToString();

    }
}