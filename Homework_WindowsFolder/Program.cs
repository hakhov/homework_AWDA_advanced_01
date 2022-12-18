using System;
using System.IO;
using System.Linq.Expressions;

namespace Homework_WindowsFolder
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Windows";

            Console.WriteLine(Directory.GetParent(path));
            Console.WriteLine(Directory.GetDirectoryRoot(path));
            Console.WriteLine(Directory.GetCreationTime(path));
            Console.WriteLine(Directory.GetLastAccessTime(path));
            Console.WriteLine(Directory.GetLastWriteTime(path));

            Console.WriteLine();
            Console.WriteLine("---------------------------FOLDERS----------------------------");
            Console.WriteLine();
            try
            {
                if (Directory.Exists(path))
                {
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string item in dirs)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("Root: " + Directory.GetDirectoryRoot(item));
                        Console.WriteLine("Creation Time: " + Directory.GetCreationTime(item));
                        Console.WriteLine("-------------------------");
                    }
                    Console.WriteLine();
                    Console.WriteLine("---------------------------FILES----------------------------");
                    Console.WriteLine();
                    string[] files = Directory.GetFiles(path);
                    foreach (string item in files)
                    {
                        FileInfo fi = null;
                        fi = new FileInfo(item);
                        Console.WriteLine("FullName: " + fi.FullName);
                        Console.WriteLine("Creation Time: " + fi.CreationTime);
                        Console.WriteLine("-------------------------");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
