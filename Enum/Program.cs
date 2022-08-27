ConsoleKeyInfo PressedKey;

while(true)
{
    PressedKey = Console.ReadKey();
    Console.WriteLine("  You pressed: "+PressedKey.Key+"\t The number of key is: "+(int)PressedKey.Key);
}
 

