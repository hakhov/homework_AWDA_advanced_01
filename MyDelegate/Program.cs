double  a= 1;
double b= 1;
double c;

MyMethodDelegate1 myMethodDelegate1 = new MyMethodDelegate1(MyMethod1);
MyMethodDelegate4 myMethodDelegate4 = (ref double a, ref double b, out double c) =>
{
    a = a + b;
    b = a + b;
    c = a + b;
    return c;
};
MyMethodDelegate3 myMethodDelegate3 =(double a,double b) =>
{ 
    a = a + b;
    b = a + b;
   return a+b;
};
Console.WriteLine();
MyMethodDelegate2 myMethodDelegate2 = (myMethodDelegate1, myMethodDelegate3, myMethodDelegate4) =>
 {
     myMethodDelegate1.Invoke();
     double k = myMethodDelegate4.Invoke(ref a, ref b, out c);
     double l= myMethodDelegate3.Invoke(a, b);
     Console.WriteLine(k+"   "+l);
     
 };

//myMethodDelegate1();
myMethodDelegate2(myMethodDelegate1,myMethodDelegate3,myMethodDelegate4);

void MyMethod1() => Console.WriteLine("MyMethod1");
//void MyMethod2() => Console.WriteLine("MyMethod2");
//void MyMethod3() => Console.WriteLine("MyMethod3");
//void MyMethod4() => Console.WriteLine("MyMethod4");
delegate void MyMethodDelegate1();
delegate double MyMethodDelegate3(double a,double b);
delegate double MyMethodDelegate4(ref double a,ref double b,out double c);
delegate void MyMethodDelegate2(MyMethodDelegate1 myMethodDelegate1, MyMethodDelegate3 myMethodDelegat3, MyMethodDelegate4 myMethodDelegate4);



