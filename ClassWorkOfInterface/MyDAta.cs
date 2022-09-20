using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkOfInterface
{
    class MyDAta : IDataProcess
    {
        public void DataProcess(IDataProvider idataProvider)
        {
            Console.WriteLine(idataProvider.GetMyData());
        }
    }
}
