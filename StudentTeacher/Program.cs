using System;

namespace StudentTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupGenerator group = new();
            group.Groups(10);
            group.ShowInfo(group, 10);
        }
    }
}
