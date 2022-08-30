//buttons
Console.WriteLine("press any button");
ConsoleKeyInfo PressedKey;
while (true)
{

    PressedKey = Console.ReadKey();
    Console.WriteLine($"You pressed key: {PressedKey.Key}");

}
