ConsoleKeyInfo key;
Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
Console.WriteLine("Press the Escape (Esc) key to quit: \n");
do
{
    key = Console.ReadKey();
    Console.Write(" --- You pressed ");
    if ((key.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
    if ((key.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
    if ((key.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
    Console.WriteLine(key.Key.ToString());
} while (key.Key != ConsoleKey.Escape);