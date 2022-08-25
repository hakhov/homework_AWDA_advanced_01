using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithNew
{
    class ClassA
    {
        public ClassB FunctionA()
        {
            return new ClassB();    
        }
    }
}
