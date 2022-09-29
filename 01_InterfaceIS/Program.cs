MyClass myClass = new MyClass();
IMyInterface myInterface = myClass as IMyInterface;

if (myClass is IMyInterface x)
{
    Console.WriteLine(myClass.DisplayInfo());
    Console.WriteLine(x.DisplayInfo());
}
else
{
    Console.WriteLine("We don't have that implementation!");
}
