using System;

namespace DelegateAsParameterOfDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Display obj = new();
            DelegateVoid delegateVoid = obj.display;
            DelegateWithDelegate x = obj.ForDelegateWithDelegate;
            x.Invoke("xxx", delegateVoid);
        }
    }
}
