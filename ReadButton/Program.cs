Console.WriteLine("Press button");
ConsoleKeyInfo input;
ConsoleKey x;
do
{
    input = Console.ReadKey(true);
    x = input.Key;
    Console.WriteLine($"You press {x} button");
}
while (x != ConsoleKey.Escape);
