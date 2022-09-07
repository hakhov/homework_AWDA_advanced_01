


using Operaot_overloading;

Point2d ob = new();
ob.year = 2000;
ob.day = 31;



Point2d ob1 = new();
ob1.year = 1500;
ob1.day = 21;

Point2d ob2 = ob - ob1;

Console.WriteLine(ob2.year + " " + ob2.day);