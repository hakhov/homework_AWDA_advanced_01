using Generics_withdelegate;

MyClass ob = new MyClass();
MyDelegate<int> myDelegate = new MyDelegate<int>(ob.func);

myDelegate.Invoke(10,52);

MyDelegate<double> myDelegate1 = new MyDelegate<double>(ob.func);

myDelegate1.Invoke(10, 25.8);


MyDelegate<bool> myDelegate2 = new MyDelegate<bool>(ob.func);

myDelegate2.Invoke(true, true);