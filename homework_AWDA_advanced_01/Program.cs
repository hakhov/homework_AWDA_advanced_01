using Example_Protected_Internal;
using Exercies;
using Fibonacci_Numbers;
using Keyboard_Enums;

Console.WriteLine("Insert Key:");
ConsoleKeyInfo key = Console.ReadKey();
Keyboard obj = new();
Console.WriteLine();
obj.Key_Name(key);


//DAY 1


////Get, Write, Sum , Max, Min, Sort functions

//ClassA ob = new ClassA();
//ClassA ob1 = new ClassA();

//Console.WriteLine("Insert the size of coulmns");
//int.TryParse(Console.ReadLine(), out int n);

//Console.WriteLine("Insert the size of rows");
//int.TryParse(Console.ReadLine(), out int m);

//Console.WriteLine("If you want to fill array automatically Insert : 1 \n" +
//    "if you want to fill manualy insert: another key");
//int.TryParse(Console.ReadLine(), out int number);

//Console.WriteLine();

//int[,] arr = new int[n, m];
//if (number == 1)
//{
//    arr = ob.Get_Arr_Auto(n, m);
//    ob.Write_Arr(arr, n, m);
//}
//else
//{
//    arr = ob1.Get_Arr_Manual(n, m);
//    ob1.Write_Arr(arr, n, m);
//}

//Console.WriteLine("If you want to find bigest item in your array insert : M");
//Console.WriteLine("If you want to find smallest item in your array insert: m");
//Console.WriteLine("If you want to sort your array insert: S");
//Console.WriteLine("If you want to know prime numbers in array insert: P");
//Console.WriteLine("If you want to know sum of items in array insert: +");

//string choose = Console.ReadLine();


//if (choose == "M")
//    Console.WriteLine($"Maximum value is:{ob.Get_Max(arr, n, m)} ");
//else if (choose == "m")
//    Console.WriteLine($"Minimum value is:{ob.Get_Min(arr, n, m)} ");
//else if (choose == "+")
//    Console.WriteLine($"Sum of numbers is: {ob.Get_Sum(arr, n, m)}");
//else if (choose == "P")
//{
//    int[] primes = ob.Get_Primes(arr, n, m);
//    ob.Write_Arr(primes);
//}
//else if (choose == "S")
//{
//    Console.WriteLine("The Array with sorted rows");
//    ob.Sort(arr, n, m);
//}


////fibonacci

//Fibonacci fibonacci = new();


//Console.Write("Insert number : ");
//int.TryParse(Console.ReadLine(), out int number1);
//Console.WriteLine(fibonacci.Get_Fib_Number(number1));


////Protected internal example

//Car newcar = new Car();

///*
//Here we can't use quality because its not assemble and not child class
//Console.WriteLine(newcar.quality);
//*/

//Mercedes c63 = new Mercedes();
//c63.Wrtie_fromMercedes();


//BMW e60 = new BMW();
//e60.Wrtie_fromBMW();







