
string path = @"C:\Windows";
Info_Diractory(path);

static void Info_Diractory(string path)
{
    var dirInfo = Directory.GetDirectories(path);

    foreach (var item in dirInfo)
    {
        Console.WriteLine(item);
    }
}