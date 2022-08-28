Console.Write("Input  0 or 1 \n Number = ");
int number = int.Parse(Console.ReadLine());

if (number == 0)
{
    Automatic automatic = new Automatic();
    Console.WriteLine();
    Console.WriteLine("Automatic Max : "+automatic.AutomaticMax());
    Console.WriteLine("Automatic MIn : "+automatic.AutomaticMin());
    Console.WriteLine("Automatic Sum : "+automatic.AutomaticSum());
    //Console.WriteLine(automatic.AutomaticSort());
}
else if(number == 1)
{   int n=int.Parse(Console.ReadLine());
    int m=int.Parse(Console.ReadLine());    
    Manual manual = new Manual(n,m);
    Console.WriteLine();
    Console.WriteLine("Automatic Max : " + manual.ManualMax());
    Console.WriteLine("Automatic MIn : " + manual.ManualMin());
    Console.WriteLine("Automatic Sum : " + manual.ManualSum());
}


