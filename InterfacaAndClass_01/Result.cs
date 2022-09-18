using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndClass_01
{
    internal class Result : ClassA, IInterface1
    {
        public override void Method()
        {
            Console.WriteLine("this is method of class");
        }

    }
}
//senc dzevov IInterfac1-i methodn el enq implementacnum,ham el Result classi method e hamarvum
