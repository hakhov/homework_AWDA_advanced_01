//Էկրանինն տպել այն ստեղնի անունը, որը սեղմվել է
ConsoleKeyInfo PressedKey;
while (true)
{
    PressedKey = Console.ReadKey();
    Console.WriteLine();
    Console.Write($"You pressed key: {PressedKey.Key}");
}

