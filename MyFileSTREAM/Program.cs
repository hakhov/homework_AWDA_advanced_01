using System.Text;

string path = @"D\Test.txt";

FileInfo fileInfo = new FileInfo(path); 
string text=Console.ReadLine();
FileStream nt = new FileStream(path,FileMode.OpenOrCreate);
byte[] buffer = Encoding.Default.GetBytes(text);
nt.Write(buffer, 0, buffer.Length);
nt.Close();