Int32 x = 5;
int y ;
//Console.WriteLine(y);//error

MyClass myClass1=new MyClass();
MyClass myClass2=new MyClass();
myClass1.Equals(myClass2);

//Console.WriteLine(myClass.Age);
MyStruct myStruct1 = new MyStruct(); 
MyStruct myStruct2 = new MyStruct();
myStruct1.Equals(myStruct2);

//Console.WriteLine(myStruct.Age);



class MyClass:Object
{
    public int Age { get; set; }
    public string Name { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine($"Age:{Age}- Name:{Name}");
    }

    public MyClass()
    {

    }
}

struct MyStruct:Base
{
    
    public MyStruct(int age, string name)
    {
        Age = age;
        Name = name;
    }
    private int Age { get; set; }
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Age:{Age}- Name:{Name}");
    }
}

interface Base
{

}
