Day day = new(365);
day.Days = 365;
Time time = day;
Time time1 = new();

Console.WriteLine(time.Y);
Console.WriteLine(time.M);
Console.WriteLine(time.D);

time1.Y = 2;
day = (Day)time1;
Console.WriteLine(day.Days);