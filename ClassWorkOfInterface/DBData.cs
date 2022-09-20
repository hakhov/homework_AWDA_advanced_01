using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkOfInterface
{
    class DBData:IDataProvider
    {
       public string GetMyData()
        {
            return "Data comes from DB";
        }
}
}
