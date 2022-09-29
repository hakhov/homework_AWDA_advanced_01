MyClass myClass = new MyClass();
IMyInterface myInterface = myClass;

//MethodFromMAIN1(myInterface);
MethodFromMAIN1(myClass);

MethodFromMAINasReturnType(myClass);
MethodFromMAINasReturnType(myInterface);

static void MethodFromMAIN(IMyInterface myInterface)
{
    myInterface.Move();
}

static void MethodFromMAIN1(MyClass myInterface)
{
    myInterface.Move();
}

static IMyInterface MethodFromMAINasReturnType(object obj)
{
    return (IMyInterface)obj;
}

