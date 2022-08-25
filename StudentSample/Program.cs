using System;

namespace homework_AWDA_advanced_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            student.setInfo(24, "Armenak");
            student.ShowInfo();
        }
    }
}
