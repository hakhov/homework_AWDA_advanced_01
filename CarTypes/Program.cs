using CarTypes;

Mercedes_Benz obj1 = new Mercedes_Benz();
BMW obj2= new BMW();
Hyundai obj3 = new Hyundai(); 
Console.Write("Input the car name(Mercedes,BMW or Hyundai) : ");
string model=Console.ReadLine();
Console.Write("Input the cost of the car : ");
double pey=double.Parse(Console.ReadLine());
Console.WriteLine();
while(model!="Close")
{   if (model == obj1.CarName1 || model ==obj2.CarName2 || model==obj3.CarName3)
    { 
        obj1.MercedesBenzType(model,pey);
        Console.WriteLine("---------------------------------");
        Console.Write("Input the car name(Mercedes,BMW or Hyundai) : ");
        model = Console.ReadLine();
        if(model == "Close")
        {
            Console.Write("\nThe cars are out of stock\n");
            break;
        }
        Console.Write("Input the cost of the car : ");
        pey = double.Parse(Console.ReadLine());
        Console.WriteLine();

    }
}