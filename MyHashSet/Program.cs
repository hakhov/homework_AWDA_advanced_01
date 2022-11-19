
using System.Collections;
MyClass ob;
var arrList1 = new ArrayList() { '{', '[', '(', ')', ']', '}' };
var arrList2 = new ArrayList() { '{', '[', '(', ']', '}', ')' };
bool val = true;
int count = arrList1.Count - 1;
foreach (var item in arrList1)
{
    ob = new MyClass(item, arrList1[count],count);
    if (!ob.MyMethod() )
    { val = false; break; }
    --count;
    if (count == (arrList1.Count - 1) / 2)
        break;
}
Console.WriteLine(val);
val = true;
count= arrList2.Count - 1;  
foreach (var item in arrList1)
{
    ob = new MyClass(item, arrList2[count], count);
    if (!ob.MyMethod())
    { val = false; break; }
    --count;
    if (count == (arrList2.Count - 1) / 2)
        break;
}
Console.WriteLine(val);


