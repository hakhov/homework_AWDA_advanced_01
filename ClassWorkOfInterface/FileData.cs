using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkOfInterface
{
    class FileData : IDataProvider
    {
        public string GetMyData()
        {
            return "Data comes from File";
        }
    }
}
