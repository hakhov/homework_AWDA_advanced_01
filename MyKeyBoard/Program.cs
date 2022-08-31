ConsoleKeyInfo sign;
Console.Write("Input sign : ");
sign = Console.ReadKey();
while (sign.Key != ConsoleKey.Escape)
{
    Console.WriteLine("\nSign : "+sign.Key+"\n Code sign : "+(int)sign.Key+"\n\n");
    Console.Write("Input sign : ");
    sign = Console.ReadKey();
}
