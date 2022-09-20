using System;

namespace ClassWorkOfInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataProcess dataProcess = new MyDAta();
            dataProcess.DataProcess(new DBData());
            dataProcess.DataProcess(new FileData());
        }
    }
}
