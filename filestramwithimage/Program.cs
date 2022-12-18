string path = @"D:\Karen\MI_9 backup\Images\DCIM";
DirectoryInfo Directory = new DirectoryInfo(path);
FileInfo[] files = Directory.GetFiles("*.jpg");

Console.WriteLine($"Found {files.Length} jpg photos");

foreach (FileInfo file in files)
{
    Console.WriteLine(file.Name);
};
