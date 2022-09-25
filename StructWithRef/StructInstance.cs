using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructWithRef
{
    public struct StructInstance
    {
        public int Instance1 { get; set; } = 45;

        public int Instance2 { get; set; } = 45;

    }

    public class MyClass
    {
        public void StructWithRef(ref StructInstance ob)
        {
            ob.Instance1 += 15;
            ob.Instance2 *= 20;
        } 


    }
}
