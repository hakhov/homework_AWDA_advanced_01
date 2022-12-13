DriveInfo[] driveInfos=DriveInfo.GetDrives();
foreach (DriveInfo driveInfo in driveInfos)
{
    string dirPath =@driveInfo.Name;
	if (Directory.Exists(dirPath))
	{
			string[] directories = Directory.GetDirectories(dirPath);
		foreach (var item in directories)
		{
			if (item == @"C:\Windows")
			{
				Console.WriteLine("YES");
				Console.WriteLine(Directory.GetParent(item));
				Console.WriteLine(Directory.GetDirectoryRoot(item)	);
				Console.WriteLine(Directory.GetCreationTime(item)	);
				Console.WriteLine(Directory.GetLastAccessTime(item)	);
				Console.WriteLine(Directory.GetCreationTime(item)	);
			}
			
		}
	}
}