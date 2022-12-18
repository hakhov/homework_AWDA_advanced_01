
//string path = @"D:\Test";
//var x = Directory.CreateDirectory(path);
//if (x.Exists)
//{
//    Directory.Delete(path, true);
//}


string fileName = @"D:\Test.txt";
FileInfo t=new FileInfo(fileName);
if (t.Exists)
{
    Console.WriteLine("Done!");
}
else
{
    Console.WriteLine("BAD");
}

string text = "Hello is a Word that means Barev"+Environment.NewLine;
//File.AppendAllLines(fileName, text.Split(Environment.NewLine.ToCharArray()).ToList<string>()); 
File.AppendAllTextAsync(fileName, text);