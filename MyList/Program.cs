using MyList;

int[] ints= new int[6] {1,3,4,5,6,7};

MyList<int> obj = new MyList<int>() ;
obj.Add(1) ;
obj.Add(2) ;
obj.Add(3) ;
obj.Add(4) ;
obj.Add(5) ;
obj.Add(6) ;

Console.WriteLine(obj.GetAtElement(0)); 
Console.WriteLine(obj.GetAtElement(1)); 
Console.WriteLine(obj.GetAtElement(2)); 
Console.WriteLine(obj.GetAtElement(3)); 
Console.WriteLine(obj.GetAtElement(4)); 
Console.WriteLine(obj.GetAtElement(5)); 

Console.WriteLine("***********************************");
obj.DeleteAtElement(3);
Console.WriteLine(obj.GetAtElement(0));
Console.WriteLine(obj.GetAtElement(1));
Console.WriteLine(obj.GetAtElement(2));
Console.WriteLine(obj.GetAtElement(3));
Console.WriteLine(obj.GetAtElement(4));
//Console.WriteLine(obj.GetAtElement(5));


MyList<int> obj1 = new MyList<int>(ints);
Console.WriteLine("___________________________________");
Console.WriteLine(obj1.GetAtElement(0));
//Console.WriteLine(obj1.GetAtElement(1));
//Console.WriteLine(obj1.GetAtElement(2));
//Console.WriteLine(obj1.GetAtElement(3));
//Console.WriteLine(obj1.GetAtElement(4));
//Console.WriteLine(obj1.GetAtElement(5));