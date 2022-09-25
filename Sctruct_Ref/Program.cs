

using StructWithRef;

StructInstance ob = new StructInstance();
MyClass ob1 = new MyClass();

Console.WriteLine($"Instance 1-{ob.Instance1} ----Instance 2 {ob.Instance2}");
ob1.StructWithRef(ref ob);
Console.WriteLine("After function");
Console.WriteLine($"Instance 1-{ob.Instance1} ----Instance 2 {ob.Instance2}");


