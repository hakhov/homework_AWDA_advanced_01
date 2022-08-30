using Enum;

ClassKey key;
ConsoleKey _key=ConsoleKey.Enter;

while(_key!=ConsoleKey.Escape)
{
    _key = Console.ReadKey().Key;
    key = new ClassKey(_key);
    key.ShowInfo();
}
 

