using System;

namespace WorkingWithDelegateAndLyambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calc calc = new Calc();
            //MyDelegate? myDelegate ;
            //MyDelegate myDelegate1 = new MyDelegate(calc.Add);
            //MyDelegate myDelegate2 = new MyDelegate(calc.Sub);
            //MyDelegate myDelegate3 = new MyDelegate(calc.Mul);
            //MyDelegate myDelegate4 = new MyDelegate(calc.Div);
            //myDelegate = myDelegate1 + myDelegate2 + myDelegate3 + myDelegate4;
            //Console.WriteLine(myDelegate.Invoke(10,14));
            MyDelegate myDelegateAdd = new MyDelegate((double num1,double num2)=> num1+num2);
            Console.WriteLine(myDelegateAdd(10,11));
            MyDelegate myDelegateSub = new MyDelegate((double num1, double num2) => num1 - num2);
            MyDelegate myDelegateMul = new MyDelegate((double num1, double num2) => num1 * num2);
            MyDelegate myDelegateDIv = new MyDelegate((double num1, double num2) => num2 != 0 ? num1 / num2 : 0);
        }
    }
}
