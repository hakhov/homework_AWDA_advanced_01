using MyLinq;


Test ints =new Test();
var filteredTest = ints.Where(a => a > 50);
foreach (var item in filteredTest)
{
    Console.WriteLine(item+" ");
}
Console.WriteLine();
var resultTest=ints.Where(a => a > 50).Select(a =>"*"+ a.ToString()+"*");
foreach (var item in resultTest)
{
    Console.WriteLine(item + " ");
}

var singleOdd= ints.First(a=> a%2==0);  
Console.WriteLine(singleOdd );
var Acc=ints.Aggregate(0,(acc,i)=>acc+i);
Console.WriteLine(Acc);