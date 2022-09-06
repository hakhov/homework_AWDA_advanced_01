Console.Write("For Automatic input number  0 and for Manual input number 1 \n\n Number = ");
int number = int.Parse(Console.ReadLine());

if (number == 0)
{
    Automatic automatic = new Automatic();
    automatic.AutomaticArray();
    Console.WriteLine();
    Console.WriteLine("Automatic Max : "+automatic.AutomaticMax());
    Console.WriteLine("Automatic Min : "+automatic.AutomaticMin());
    Console.WriteLine("Automatic Sum : "+automatic.AutomaticSum());
    automatic.AutomaticPrime();
}
else if(number == 1)
{
    Console.Write("n = ");
    int n=int.Parse(Console.ReadLine());
    Console.Write("m = ");
    int m = int.Parse(Console.ReadLine());
    Manual manual = new Manual(n,m);
    Console.WriteLine();
    Console.WriteLine("Manual Max : " + manual.ManualMax());
    Console.WriteLine("Manual MIn : " + manual.ManualMin());
    Console.WriteLine("Manual Sum : " + manual.ManualSum());
}


